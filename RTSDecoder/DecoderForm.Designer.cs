namespace RTSDecoder
{
    partial class DecoderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecoderForm));
            this.decodeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statOtherA = new System.Windows.Forms.Label();
            this.statUR = new System.Windows.Forms.Label();
            this.statSpeed = new System.Windows.Forms.Label();
            this.statSpeedA = new System.Windows.Forms.Label();
            this.statBrakeA = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(18, 124);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(224, 23);
            this.decodeButton.TabIndex = 2;
            this.decodeButton.Text = "Начать";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statOtherA);
            this.groupBox2.Controls.Add(this.statUR);
            this.groupBox2.Controls.Add(this.statSpeed);
            this.groupBox2.Controls.Add(this.statSpeedA);
            this.groupBox2.Controls.Add(this.statBrakeA);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // statOtherA
            // 
            this.statOtherA.Location = new System.Drawing.Point(6, 84);
            this.statOtherA.Name = "statOtherA";
            this.statOtherA.Size = new System.Drawing.Size(224, 17);
            this.statOtherA.TabIndex = 7;
            this.statOtherA.Text = "Прочие нарушения: 0";
            this.statOtherA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statUR
            // 
            this.statUR.Location = new System.Drawing.Point(6, 33);
            this.statUR.Name = "statUR";
            this.statUR.Size = new System.Drawing.Size(224, 17);
            this.statUR.TabIndex = 1;
            this.statUR.Text = "Максимальное давление УР: 0.00 кг/с";
            this.statUR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statSpeed
            // 
            this.statSpeed.Location = new System.Drawing.Point(6, 16);
            this.statSpeed.Name = "statSpeed";
            this.statSpeed.Size = new System.Drawing.Size(224, 17);
            this.statSpeed.TabIndex = 0;
            this.statSpeed.Text = "Средняя скорость: 0 км/ч";
            this.statSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statSpeedA
            // 
            this.statSpeedA.Location = new System.Drawing.Point(6, 67);
            this.statSpeedA.Name = "statSpeedA";
            this.statSpeedA.Size = new System.Drawing.Size(224, 17);
            this.statSpeedA.TabIndex = 6;
            this.statSpeedA.Text = "Нарушения по скоростям: 0";
            this.statSpeedA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statBrakeA
            // 
            this.statBrakeA.Location = new System.Drawing.Point(6, 50);
            this.statBrakeA.Name = "statBrakeA";
            this.statBrakeA.Size = new System.Drawing.Size(224, 17);
            this.statBrakeA.TabIndex = 5;
            this.statBrakeA.Text = "Нарушения по тормозам: 0";
            this.statBrakeA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(18, 153);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(224, 23);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Результаты";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // DecoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 189);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.decodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DecoderForm";
            this.Text = "Авторасшифровка";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label statUR;
        private System.Windows.Forms.Label statBrakeA;
        private System.Windows.Forms.Label statSpeedA;
        private System.Windows.Forms.Label statOtherA;

        private System.Windows.Forms.Label statSpeed;

        #endregion

        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button resultButton;
    }
}