using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RTSDecoder
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = TrainData.Main;

            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm:ss";

            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "HH:mm:ss";

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "ID";
            idColumn.HeaderText = "ID";
            dataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn gameTimeColumn = new DataGridViewTextBoxColumn();
            gameTimeColumn.DataPropertyName = "Time";
            gameTimeColumn.HeaderText = "Время (Игровое)";
            gameTimeColumn.DefaultCellStyle.Format = "HH:mm:ss tt";
            dataGridView.Columns.Add(gameTimeColumn);

            DataGridViewTextBoxColumn realTimeColumn = new DataGridViewTextBoxColumn();
            realTimeColumn.DataPropertyName = "RealTime";
            realTimeColumn.HeaderText = "Время (Реальное)";
            realTimeColumn.DefaultCellStyle.Format = "HH:mm:ss tt";
            dataGridView.Columns.Add(realTimeColumn);

            DataGridViewTextBoxColumn speedColumn = new DataGridViewTextBoxColumn();
            speedColumn.DataPropertyName = "Speed";
            speedColumn.HeaderText = "Скорость";
            speedColumn.DefaultCellStyle.Format = "#0.0 км/ч";
            dataGridView.Columns.Add(speedColumn);

            DataGridViewTextBoxColumn speedLimitColumn = new DataGridViewTextBoxColumn();
            speedLimitColumn.DataPropertyName = "SpeedLimit";
            speedLimitColumn.HeaderText = "Ограничение";
            speedLimitColumn.DefaultCellStyle.Format = "#0 км/ч";
            dataGridView.Columns.Add(speedLimitColumn);

            DataGridViewTextBoxColumn speedVectorColumn = new DataGridViewTextBoxColumn();
            speedVectorColumn.DataPropertyName = "SpeedVector";
            speedVectorColumn.HeaderText = "Направление движения (Каб 1)";
            dataGridView.Columns.Add(speedVectorColumn);

            DataGridViewTextBoxColumn signalColumn = new DataGridViewTextBoxColumn();
            signalColumn.DataPropertyName = "Signal";
            signalColumn.HeaderText = "Сигнал";
            dataGridView.Columns.Add(signalColumn);

            DataGridViewTextBoxColumn sSignalColumn = new DataGridViewTextBoxColumn();
            sSignalColumn.DataPropertyName = "SSignal";
            sSignalColumn.HeaderText = "До сигнала";
            sSignalColumn.DefaultCellStyle.Format = "#0 м";
            dataGridView.Columns.Add(sSignalColumn);

            DataGridViewTextBoxColumn kmpiketColumn = new DataGridViewTextBoxColumn();
            kmpiketColumn.DataPropertyName = "KMPK";
            kmpiketColumn.HeaderText = "КМ ПК";
            kmpiketColumn.DefaultCellStyle.Format = "#0 км 0 пк";
            dataGridView.Columns.Add(kmpiketColumn);

            DataGridViewTextBoxColumn posColumn = new DataGridViewTextBoxColumn();
            posColumn.DataPropertyName = "Pos";
            posColumn.HeaderText = "Ордината";
            posColumn.DefaultCellStyle.Format = "#0.0 м";
            dataGridView.Columns.Add(posColumn);

            DataGridViewTextBoxColumn eptColumn = new DataGridViewTextBoxColumn();
            eptColumn.DataPropertyName = "EPT";
            eptColumn.HeaderText = "ЭПТ";
            dataGridView.Columns.Add(eptColumn);

            DataGridViewTextBoxColumn sandColumn = new DataGridViewTextBoxColumn();
            sandColumn.DataPropertyName = "Sand";
            sandColumn.HeaderText = "Песок";
            dataGridView.Columns.Add(sandColumn);

            DataGridViewTextBoxColumn kmColumn = new DataGridViewTextBoxColumn();
            kmColumn.DataPropertyName = "KM";
            kmColumn.HeaderText = "Позиция";
            dataGridView.Columns.Add(kmColumn);

            DataGridViewTextBoxColumn tmColumn = new DataGridViewTextBoxColumn();
            tmColumn.DataPropertyName = "TM";
            tmColumn.HeaderText = "ТМ";
            tmColumn.DefaultCellStyle.Format = "#0.0 кгс/см2";
            dataGridView.Columns.Add(tmColumn);

            DataGridViewTextBoxColumn urColumn = new DataGridViewTextBoxColumn();
            urColumn.DataPropertyName = "UR";
            urColumn.HeaderText = "УР";
            urColumn.DefaultCellStyle.Format = "#0.0 кгс/см2";
            dataGridView.Columns.Add(urColumn);

            DataGridViewTextBoxColumn tcColumn = new DataGridViewTextBoxColumn();
            tcColumn.DataPropertyName = "TC";
            tcColumn.HeaderText = "ТЦ";
            tcColumn.DefaultCellStyle.Format = "#0.0 кгс/см2";
            dataGridView.Columns.Add(tcColumn);

            DataGridViewTextBoxColumn lmColumn = new DataGridViewTextBoxColumn();
            lmColumn.DataPropertyName = "LM";
            lmColumn.HeaderText = "ЛТ";
            dataGridView.Columns.Add(lmColumn);

            DataGridViewTextBoxColumn pathColumn = new DataGridViewTextBoxColumn();
            pathColumn.DataPropertyName = "Path";
            pathColumn.HeaderText = "Профиль";
            pathColumn.DefaultCellStyle.Format = "N2";
            dataGridView.Columns.Add(pathColumn);

            DataGridViewTextBoxColumn odoColumn = new DataGridViewTextBoxColumn();
            odoColumn.DataPropertyName = "Odo";
            odoColumn.HeaderText = "Пробег";
            odoColumn.DefaultCellStyle.Format = "#0 км";
            dataGridView.Columns.Add(odoColumn);

            DataGridViewTextBoxColumn locosColumn = new DataGridViewTextBoxColumn();
            locosColumn.DataPropertyName = "Locos";
            locosColumn.HeaderText = "Локомотивов";
            locosColumn.DefaultCellStyle.Format = "#0 ед";
            dataGridView.Columns.Add(locosColumn);

            DataGridViewTextBoxColumn wagsColumn = new DataGridViewTextBoxColumn();
            wagsColumn.DataPropertyName = "Wags";
            wagsColumn.HeaderText = "Вагонов";
            wagsColumn.DefaultCellStyle.Format = "#0 ед";
            dataGridView.Columns.Add(wagsColumn);

            DataGridViewTextBoxColumn massColumn = new DataGridViewTextBoxColumn();
            massColumn.DataPropertyName = "Mass";
            massColumn.HeaderText = "Масса";
            massColumn.DefaultCellStyle.Format = "#0 тонн";
            dataGridView.Columns.Add(massColumn);

            DataGridViewTextBoxColumn lengthColumn = new DataGridViewTextBoxColumn();
            lengthColumn.DataPropertyName = "Length";
            lengthColumn.HeaderText = "Длинна";
            lengthColumn.DefaultCellStyle.Format = "#0.00 м";
            dataGridView.Columns.Add(lengthColumn);

            DataGridViewTextBoxColumn fuelColumn = new DataGridViewTextBoxColumn();
            fuelColumn.DataPropertyName = "Fuel";
            fuelColumn.HeaderText = "Расход";
            fuelColumn.DefaultCellStyle.Format = "#0.0 кВт/ч, л/ч";
            dataGridView.Columns.Add(fuelColumn);

            if (dataGridView.Rows.Count > 0)
            {
                DateTime maxTime = DateTime.MinValue;
                DateTime minTime = DateTime.MaxValue;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells[1].Value != null)
                    {
                        DateTime time = Convert.ToDateTime(row.Cells[1].Value);

                        if (time > maxTime)
                        {
                            maxTime = time;
                        }
                        if (time < minTime)
                        {
                            minTime = time;
                        }
                    }
                }
                dtpStartTime.Value = minTime;
                dtpStartTime.MinDate = minTime;
                dtpStartTime.MaxDate = maxTime;

                dtpEndTime.Value = maxTime;
                dtpEndTime.MinDate = minTime;
                dtpEndTime.MaxDate = maxTime;
            }
        }

        private void showRedSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (showRedSpeed.Checked)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    double value1 = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value);
                    double value2 = Convert.ToDouble(dataGridView.Rows[i].Cells[4].Value);

                    if (value1 > value2) { dataGridView.Rows[i].Cells[3].Style.BackColor = Color.Red; }
                }
            }
        }

        private void dtpTimeZone_ValueChanged(object sender, EventArgs e)
        {
            DateTime startTime = dtpStartTime.Value;
            DateTime endTime = dtpEndTime.Value;

            List<MovementData> dataList = TrainData.Main;
            List<MovementData> filteredDataList = dataList.Where(item => item.Time >= startTime && item.Time <= endTime).ToList();

            dataGridView.DataSource = filteredDataList;
        }
    }
}
