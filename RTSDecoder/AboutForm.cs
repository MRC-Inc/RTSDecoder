using System;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace RTSDecoder
{
    public partial class AboutForm : Form
    {
        private readonly string[] _labelText = { "Разработчик", "Developer", "Zpracovatel", "Entwickler", "開發商", "Розробник" };
        private int _labelIndex;
        private readonly Timer _timer;
        private int _hue;

        public AboutForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;

            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            label2.Text = String.Format("Текущая версия: {0}", appVersion);

            _timer = new Timer
            {
                Interval = 100
            };
            _timer.Tick += TimerTick;

            _hue = 0;

            _timer.Start();
        }


        private void TimerTick(object sender, EventArgs e)
        {
            if (_labelIndex >= _labelText.Length) { _labelIndex = 0; }

            Color color = ColorFromHsl(_hue, 1, 0.5);
            label3.ForeColor = color;

            _hue += 5;

            if (_hue >= 360)
            {
                _hue = 0;

                label3.Text = String.Format("{0} - Mr_Claush", _labelText[_labelIndex]);
                _labelIndex++;
            }
        }

        private Color ColorFromHsl(int hue, double saturation, double lightness)
        {
            double chroma = (1 - Math.Abs(2 * lightness - 1)) * saturation;
            double huePrime = hue / 60.0;
            double x = chroma * (1 - Math.Abs(huePrime % 2 - 1));
            double r1, g1, b1;

            if (huePrime >= 0 && huePrime < 1)
            {
                r1 = chroma;
                g1 = x;
                b1 = 0;
            }
            else if (huePrime >= 1 && huePrime < 2)
            {
                r1 = x;
                g1 = chroma;
                b1 = 0;
            }
            else if (huePrime >= 2 && huePrime < 3)
            {
                r1 = 0;
                g1 = chroma;
                b1 = x;
            }
            else if (huePrime >= 3 && huePrime < 4)
            {
                r1 = 0;
                g1 = x;
                b1 = chroma;
            }
            else if (huePrime >= 4 && huePrime < 5)
            {
                r1 = x;
                g1 = 0;
                b1 = chroma;
            }
            else
            {
                r1 = chroma;
                g1 = 0;
                b1 = x;
            }

            double m = lightness - chroma / 2;
            int r = Convert.ToInt32((r1 + m) * 255);
            int g = Convert.ToInt32((g1 + m) * 255);
            int b = Convert.ToInt32((b1 + m) * 255);

            return Color.FromArgb(r, g, b);
        }
    }
}
