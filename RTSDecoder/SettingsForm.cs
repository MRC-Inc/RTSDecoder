using System;
using System.Windows.Forms;

namespace RTSDecoder
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;

            colorDialog.FullOpen = true;

            settingShowTime.SelectedIndex = Properties.Settings.Default.showRealTime;

            btnTMColor.BackColor = Properties.Settings.Default.axisTMColor;
            btnURColor.BackColor = Properties.Settings.Default.axisURColor;
            btnTCColor.BackColor = Properties.Settings.Default.axisTCColor;
            btnLMColor.BackColor = Properties.Settings.Default.axisLMColor;
            btnSpeedColor.BackColor = Properties.Settings.Default.axisSpeedColor;
            btnSpeedLimitColor.BackColor = Properties.Settings.Default.axisSpeedLimitColor;
            btnPathColor.BackColor = Properties.Settings.Default.axisPathColor;

            btnTMColor.Click += BtnColor_Click;
            btnURColor.Click += BtnColor_Click;
            btnTCColor.Click += BtnColor_Click;
            btnLMColor.Click += BtnColor_Click;
            btnSpeedColor.Click += BtnColor_Click;
            btnSpeedLimitColor.Click += BtnColor_Click;
            btnPathColor.Click += BtnColor_Click; 
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.showRealTime = settingShowTime.SelectedIndex;
            Properties.Settings.Default.axisTMColor = btnTMColor.BackColor;
            Properties.Settings.Default.axisURColor = btnURColor.BackColor;
            Properties.Settings.Default.axisTCColor = btnTCColor.BackColor;
            Properties.Settings.Default.axisLMColor = btnLMColor.BackColor;
            Properties.Settings.Default.axisSpeedColor = btnSpeedColor.BackColor;
            Properties.Settings.Default.axisSpeedLimitColor = btnSpeedLimitColor.BackColor;
            Properties.Settings.Default.axisPathColor = btnPathColor.BackColor;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            ((Button)sender).BackColor = colorDialog.Color;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Восстановление настроек", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
            }
        }
    }
}
