namespace RTSDecoder
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingShowTime = new System.Windows.Forms.ComboBox();
            this.btnTMColor = new System.Windows.Forms.Button();
            this.colorSettings = new System.Windows.Forms.GroupBox();
            this.btnPathColor = new System.Windows.Forms.Button();
            this.btnSpeedLimitColor = new System.Windows.Forms.Button();
            this.btnSpeedColor = new System.Windows.Forms.Button();
            this.btnLMColor = new System.Windows.Forms.Button();
            this.btnTCColor = new System.Windows.Forms.Button();
            this.btnURColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.resetButton = new System.Windows.Forms.Button();
            this.colorSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отображаемое время на графиках";
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(0, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(304, 32);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // settingShowTime
            // 
            this.settingShowTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingShowTime.FormattingEnabled = true;
            this.settingShowTime.Items.AddRange(new object[] { "Игровое", "Реальное" });
            this.settingShowTime.Location = new System.Drawing.Point(15, 38);
            this.settingShowTime.Name = "settingShowTime";
            this.settingShowTime.Size = new System.Drawing.Size(277, 21);
            this.settingShowTime.TabIndex = 0;
            // 
            // btnTMColor
            // 
            this.btnTMColor.AutoSize = true;
            this.btnTMColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTMColor.Location = new System.Drawing.Point(3, 16);
            this.btnTMColor.Name = "btnTMColor";
            this.btnTMColor.Size = new System.Drawing.Size(271, 25);
            this.btnTMColor.TabIndex = 4;
            this.btnTMColor.Text = "ТМ";
            this.btnTMColor.UseVisualStyleBackColor = true;
            // 
            // colorSettings
            // 
            this.colorSettings.Controls.Add(this.btnPathColor);
            this.colorSettings.Controls.Add(this.btnSpeedLimitColor);
            this.colorSettings.Controls.Add(this.btnSpeedColor);
            this.colorSettings.Controls.Add(this.btnLMColor);
            this.colorSettings.Controls.Add(this.btnTCColor);
            this.colorSettings.Controls.Add(this.btnURColor);
            this.colorSettings.Controls.Add(this.btnTMColor);
            this.colorSettings.Location = new System.Drawing.Point(15, 65);
            this.colorSettings.Name = "colorSettings";
            this.colorSettings.Size = new System.Drawing.Size(277, 183);
            this.colorSettings.TabIndex = 6;
            this.colorSettings.TabStop = false;
            this.colorSettings.Text = "Настройка цветов";
            // 
            // btnPathColor
            // 
            this.btnPathColor.AutoSize = true;
            this.btnPathColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPathColor.Location = new System.Drawing.Point(3, 156);
            this.btnPathColor.Name = "btnPathColor";
            this.btnPathColor.Size = new System.Drawing.Size(271, 23);
            this.btnPathColor.TabIndex = 10;
            this.btnPathColor.Text = "Профиль";
            this.btnPathColor.UseVisualStyleBackColor = true;
            // 
            // btnSpeedLimitColor
            // 
            this.btnSpeedLimitColor.AutoSize = true;
            this.btnSpeedLimitColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpeedLimitColor.Location = new System.Drawing.Point(3, 133);
            this.btnSpeedLimitColor.Name = "btnSpeedLimitColor";
            this.btnSpeedLimitColor.Size = new System.Drawing.Size(271, 23);
            this.btnSpeedLimitColor.TabIndex = 9;
            this.btnSpeedLimitColor.Text = "Ограничение";
            this.btnSpeedLimitColor.UseVisualStyleBackColor = true;
            // 
            // btnSpeedColor
            // 
            this.btnSpeedColor.AutoSize = true;
            this.btnSpeedColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpeedColor.Location = new System.Drawing.Point(3, 110);
            this.btnSpeedColor.Name = "btnSpeedColor";
            this.btnSpeedColor.Size = new System.Drawing.Size(271, 23);
            this.btnSpeedColor.TabIndex = 8;
            this.btnSpeedColor.Text = "Скорость";
            this.btnSpeedColor.UseVisualStyleBackColor = true;
            // 
            // btnLMColor
            // 
            this.btnLMColor.AutoSize = true;
            this.btnLMColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLMColor.Location = new System.Drawing.Point(3, 87);
            this.btnLMColor.Name = "btnLMColor";
            this.btnLMColor.Size = new System.Drawing.Size(271, 23);
            this.btnLMColor.TabIndex = 7;
            this.btnLMColor.Text = "Локомотивный";
            this.btnLMColor.UseVisualStyleBackColor = true;
            // 
            // btnTCColor
            // 
            this.btnTCColor.AutoSize = true;
            this.btnTCColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTCColor.Location = new System.Drawing.Point(3, 64);
            this.btnTCColor.Name = "btnTCColor";
            this.btnTCColor.Size = new System.Drawing.Size(271, 23);
            this.btnTCColor.TabIndex = 6;
            this.btnTCColor.Text = "ТЦ";
            this.btnTCColor.UseVisualStyleBackColor = true;
            // 
            // btnURColor
            // 
            this.btnURColor.AutoSize = true;
            this.btnURColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnURColor.Location = new System.Drawing.Point(3, 41);
            this.btnURColor.Name = "btnURColor";
            this.btnURColor.Size = new System.Drawing.Size(271, 23);
            this.btnURColor.TabIndex = 5;
            this.btnURColor.Text = "УР";
            this.btnURColor.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resetButton.Location = new System.Drawing.Point(0, 297);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(304, 32);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Восстановить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.colorSettings);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingShowTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.colorSettings.ResumeLayout(false);
            this.colorSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox settingShowTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button btnTMColor;
        private System.Windows.Forms.GroupBox colorSettings;
        private System.Windows.Forms.Button btnSpeedLimitColor;
        private System.Windows.Forms.Button btnSpeedColor;
        private System.Windows.Forms.Button btnLMColor;
        private System.Windows.Forms.Button btnTCColor;
        private System.Windows.Forms.Button btnURColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button btnPathColor;
    }
}