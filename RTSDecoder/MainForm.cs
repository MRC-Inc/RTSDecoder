using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using System.Linq;

namespace RTSDecoder
{
    public partial class MainForm : Form
    {
        TableForm _tableForm;
        SettingsForm _settingsForm;
        AboutForm _aboutForm;
        DecoderForm _decoderForm;

        readonly int _showRealTime = Properties.Settings.Default.showRealTime;

        readonly OxyColor _tmColor = Properties.Settings.Default.axisTMColor.ToOxyColor();
        readonly OxyColor _urColor = Properties.Settings.Default.axisURColor.ToOxyColor();
        readonly OxyColor _tcColor = Properties.Settings.Default.axisTCColor.ToOxyColor();
        readonly OxyColor _lmColor = Properties.Settings.Default.axisLMColor.ToOxyColor();
        readonly OxyColor _speedColor = Properties.Settings.Default.axisSpeedColor.ToOxyColor();
        readonly OxyColor _speedLimitColor = Properties.Settings.Default.axisSpeedLimitColor.ToOxyColor();
        readonly OxyColor _pathColor = Properties.Settings.Default.axisPathColor.ToOxyColor();

        string _filePath = "";
        string _lastFile = Properties.Settings.Default.lastFile;
        public MainForm(Thread splashscreenthread)
        {
            this.InitializeComponent();
            splashscreenthread.Abort();
            
            var motionData = ReadMovementData(_filePath);

            BuildMainGraph(motionData);
        }

        private void BuildMainGraph(List<MovementData> motionData)
        {
            var mainGraphModel = new PlotModel
            {
                Title = "Параметры движения",
            };

            var tmLine = new LineSeries
            {
                Title = "Давление ТМ",
                Color = _tmColor,
                TrackerFormatString = "{0}\n{1}: {2:HH:mm:ss}\nЗначение: {4:#0.00 кгс/см2}"
            };

            var urLine = new LineSeries
            {
                Title = "Давление УР",
                Color = _urColor,
                TrackerFormatString = "{0}\n{1}: {2:HH:mm:ss}\nЗначение: {4:#0.00 кгс/см2}"
            };

            var tcLine = new LineSeries
            {
                Title = "Давление ТЦ",
                Color = _tcColor,
                TrackerFormatString = "{0}\n{1}: {2:HH:mm:ss}\nЗначение: {4:#0.00 кгс/см2}"
            };

            var lmLine = new StairStepSeries
            {
                Title = "Локомотивный",
                Color = _lmColor,
                TrackerFormatString = "{0}\n{1}: {2:HH:mm:ss}\nЗначение: {4:#}"
            };

            var speedLine = new LineSeries
            {
                Title = "Скорость",
                Color = _speedColor,
                TrackerFormatString = "{0}\n{1}: {2:HH:mm:ss}\nЗначение: {4:#0.00 км/ч}"
            };

            var limitLine = new StairStepSeries
            {
                Title = "Ограничение",
                Color = _speedLimitColor,
                TrackerFormatString = "{0}\n{1}: {2:HH:mm:ss}\nЗначение: {4:# км/ч}"
            };

            var pathLine = new StairStepSeries
            {
                Title = "Профиль",
                Color = _pathColor
            };

            var timeAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Время",
                StringFormat = "HH:mm:ss",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalType = DateTimeIntervalType.Hours,
                IntervalLength = 60
            };
            mainGraphModel.Axes.Add(timeAxis);

            var parameterAxis = new LinearAxis
            {
                StartPosition = 0.50,
                Position = AxisPosition.Left,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                AbsoluteMaximum = 9,
                AbsoluteMinimum = -1,
                Title = "Тормоза",
                Unit = "кгс/см2",
                Key = "Main"
            };
            mainGraphModel.Axes.Add(parameterAxis);

            var parameterSpeedAxis = new LinearAxis
            {
                StartPosition = 0.20,
                EndPosition = 0.50,
                Position = AxisPosition.Left,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                AbsoluteMaximum = 400,
                AbsoluteMinimum = -50,
                Title = "Скорость",
                Unit = "км/ч",
                Key = "Speed"
            };
            mainGraphModel.Axes.Add(parameterSpeedAxis);

            var parameterPathAxis = new LinearAxis
            {
                EndPosition = 0.20,
                Position = AxisPosition.Left,
                Title = "Профиль",
                Key = "Path"
            };
            mainGraphModel.Axes.Add(parameterPathAxis);

            foreach (MovementData data in motionData)
            {
                var time = data.Time;
                if (_showRealTime == 1) { time = data.RealTime; }

                tmLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.Tm));
                tmLine.YAxisKey = "Main";
                urLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.Ur));
                urLine.YAxisKey = "Main";
                tcLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.Tc));
                tcLine.YAxisKey = "Main";
                lmLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.Lm));
                lmLine.YAxisKey = "Main";

                speedLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.Speed));
                speedLine.YAxisKey = "Speed";
                limitLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.SpeedLimit));
                limitLine.YAxisKey = "Speed";

                pathLine.Points.Add(new DataPoint(DateTimeAxis.ToDouble(time), data.Path));
                pathLine.YAxisKey = "Path";
            }

            mainGraphModel.Series.Add(tmLine);
            mainGraphModel.Series.Add(urLine);
            mainGraphModel.Series.Add(tcLine);
            mainGraphModel.Series.Add(lmLine);
            mainGraphModel.Series.Add(speedLine);
            mainGraphModel.Series.Add(limitLine);
            mainGraphModel.Series.Add(pathLine);

            mainGraph.Model = mainGraphModel;
        }

        static List<MovementData> ReadMovementData(string filePath)
        {
            List<MovementData> movementDataList = TrainData.Main;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int i = 0;
                double ord = 0;

                foreach (string line in lines)
                {
                    string[] parts = line.Split('#');

                    // Форматирование скорости
                    string speedVector = "-";
                    double v = double.Parse(parts[0], System.Globalization.CultureInfo.InvariantCulture);
                    if (v < 0) { v = -v; speedVector = "←"; } else if (v > 0) { speedVector = "→"; }
                    
                    double curSpeed = v * 3.6;
                    double limit = double.Parse(parts[44], System.Globalization.CultureInfo.InvariantCulture) * 3.6;

                    // Пробеги и местоположение
                    ord = ord + v;
                    double kmpiket = double.Parse(parts[46], System.Globalization.CultureInfo.InvariantCulture);

                    // Форматирование времени
                    string[] theTimeArray = new string[] { parts[1], parts[2], parts[3] };
                    string gameTime = string.Join(":", theTimeArray);

                    // Форматирование реального времени
                    string[] theRealTimeArray = new string[] { parts[30], parts[31], parts[32] };
                    string realTime = string.Join(":", theRealTimeArray);

                    double curKm = double.Parse(parts[19], System.Globalization.CultureInfo.InvariantCulture);

                    // Форматирование давлений ТМ, УР, ТЦ
                    double curTm = double.Parse(parts[6], System.Globalization.CultureInfo.InvariantCulture) / 14.69;
                    double curUr = double.Parse(parts[45], System.Globalization.CultureInfo.InvariantCulture) / 14.69;
                    double curTc = double.Parse(parts[8], System.Globalization.CultureInfo.InvariantCulture) / 14.69;
                    double curLm = double.Parse(parts[7], System.Globalization.CultureInfo.InvariantCulture) / 14.69;

                    // ЭПТ
                    int curEpt = Convert.ToInt32(double.Parse(parts[41], System.Globalization.CultureInfo.InvariantCulture));

                    string statusEpt = "-";
                    switch (curEpt)
                    {
                        case 0:
                            statusEpt = "Выкл";
                            break;
                        case 1:
                            statusEpt = "Вкл";
                            break;
                    }

                    int curSand = Convert.ToInt32(double.Parse(parts[28], System.Globalization.CultureInfo.InvariantCulture));
                    
                    // Песок
                    string statusSand = "-";
                    switch (curSand)
                    {
                        case 0:
                            statusSand = "Выкл";
                            break;
                        case 1:
                            statusSand = "Вкл";
                            break;
                    }

                    int signal = int.Parse(parts[4]);
                    int sSignal = Convert.ToInt32(double.Parse(parts[9], System.Globalization.CultureInfo.InvariantCulture));

                    string signalTitle = "-";
                    switch (signal)
                    {
                        case 1:
                            signalTitle = "КЖ";
                            if (sSignal <= 400 && sSignal > 100) { limit = 20; } else if (sSignal <= 100) { limit = 5; }
                            break;
                        case 2:
                            signalTitle = "Б";
                            break;
                        case 3:
                            signalTitle = "Ж";
                            break;
                        case 4:
                            signalTitle = "Ж-Ж";
                            break;
                        case 5:
                            signalTitle = "Ж";
                            break;
                        case 6:
                            signalTitle = "З";
                            break;
                        case 7:
                            signalTitle = "З";
                            break;
                        case 8:
                            signalTitle = "К";
                            break;
                    }

                    double curPath = double.Parse(parts[12], System.Globalization.CultureInfo.InvariantCulture);

                    int curLocos = Convert.ToInt32(double.Parse(parts[35], System.Globalization.CultureInfo.InvariantCulture));
                    int curWags = Convert.ToInt32(double.Parse(parts[34], System.Globalization.CultureInfo.InvariantCulture)) - curLocos;

                    int curMass = Convert.ToInt32(double.Parse(parts[33], System.Globalization.CultureInfo.InvariantCulture)) / 1000;
                    double curLength = double.Parse(parts[37], System.Globalization.CultureInfo.InvariantCulture);
                    double curFuel = double.Parse(parts[29], System.Globalization.CultureInfo.InvariantCulture);
                    //Console.WriteLine($"Ошибка при чтении данных: {curTM}, {curLM}, {curTC}");

                    MovementData data = new MovementData
                    {
                        Id = i,
                        Speed = Math.Round(curSpeed, 3),
                        SpeedLimit = Math.Round(limit),
                        SpeedVector = speedVector,
                        Time = DateTime.Parse(gameTime),
                        RealTime = DateTime.Parse(realTime),
                        Tm = Math.Round(curTm, 3),
                        Ur = Math.Round(curUr, 3),
                        Tc = Math.Round(curTc, 3),
                        Lm = Math.Round(curLm),
                        Ept = statusEpt,
                        Sand = statusSand,
                        Signal = signalTitle,
                        SSignal = sSignal,
                        Path = Math.Round(curPath, 2),
                        Pos = ord,
                        Kmpk = kmpiket,
                        Odo = Math.Round(ord / 1000, 2),
                        Km = Math.Round(curKm),
                        Locos = curLocos,
                        Wags = curWags,
                        Mass = curMass,
                        Length = curLength,
                        Fuel = Math.Round(curFuel, 2)
                    };
                    movementDataList.Add(data);
                    i++;
                    //movementDataList.Sort();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении данных: {ex.Message}");
            }
            return movementDataList;
        }

        private void SetWindowTitle(string fileName)
        {
            this.Text = string.Format("Просмотр ленты - {0}", Path.GetFileName(fileName));
        }

        private void TopFileMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _filePath = ofd.FileName;
            }

            TrainData.Main.Clear();
            WizardData.Main.Clear();

            var motionData = ReadMovementData(_filePath);
            
            SetWindowTitle(_filePath);
            BuildMainGraph(motionData);

            _lastFile = _filePath;
            Properties.Settings.Default.lastFile = _filePath;
            Properties.Settings.Default.Save();
        }

        private void TopFileMenuOpenLast_Click(object sender, EventArgs e)
        {
            if (_lastFile != null)
            {
                TrainData.Main.Clear();
                WizardData.Main.Clear();
                var motionData = ReadMovementData(_lastFile);

                SetWindowTitle(_lastFile);
                BuildMainGraph(motionData);

                Properties.Settings.Default.lastFile = _lastFile;
                Properties.Settings.Default.Save();
            }
        }

        private void topFileMenuSplit_Click(object sender, EventArgs e)
        {
            var movementDataList = TrainData.Main;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] filePaths = openFileDialog.FileNames;

                    foreach (string filePath in filePaths)
                    {
                        ReadMovementData(filePath);
                    }

                    SetWindowTitle(filePaths[0]);
                    BuildMainGraph(movementDataList);
                }
            }
        }

        private void TopOpenTableForm_Click(object sender, EventArgs e)
        {
            _tableForm = new TableForm();
            _tableForm.Show();
        }

        private void TopSettings_Click(object sender, EventArgs e)
        {
            _settingsForm = new SettingsForm();
            _settingsForm.ShowDialog();
        }

        private void TopAbout_Click(object sender, EventArgs e)
        {
            _aboutForm = new AboutForm();
            _aboutForm.ShowDialog();
        }

        private void topDecoder_Click(object sender, EventArgs e)
        {
            if (TrainData.Main.Any())
            {
                _decoderForm = new DecoderForm();
                _decoderForm.Show();
            } else
            {
                MessageBox.Show("Нет данных для расшифровки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
