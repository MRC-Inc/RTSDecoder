namespace RTSDecoder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainGraph = new OxyPlot.WindowsForms.PlotView();
            this.graphGroup = new System.Windows.Forms.GroupBox();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.topFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.topFileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.topFileMenuOpenLast = new System.Windows.Forms.ToolStripMenuItem();
            this.topFileMenuSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.topOpenTableForm = new System.Windows.Forms.ToolStripMenuItem();
            this.topDecoder = new System.Windows.Forms.ToolStripMenuItem();
            this.topSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.topAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.graphGroup.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.graphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGraph
            // 
            this.mainGraph.BackColor = System.Drawing.Color.Gainsboro;
            this.mainGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGraph.Location = new System.Drawing.Point(8, 21);
            this.mainGraph.Name = "mainGraph";
            this.mainGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.mainGraph.Size = new System.Drawing.Size(980, 599);
            this.mainGraph.TabIndex = 0;
            this.mainGraph.Text = "mainGraph";
            this.mainGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.mainGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.mainGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // graphGroup
            // 
            this.graphGroup.AutoSize = true;
            this.graphGroup.Controls.Add(this.mainGraph);
            this.graphGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphGroup.Location = new System.Drawing.Point(6, 3);
            this.graphGroup.Name = "graphGroup";
            this.graphGroup.Padding = new System.Windows.Forms.Padding(8);
            this.graphGroup.Size = new System.Drawing.Size(996, 628);
            this.graphGroup.TabIndex = 1;
            this.graphGroup.TabStop = false;
            this.graphGroup.Text = "Графики параметров";
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.topFileMenu, this.topOpenTableForm, this.topDecoder, this.topSettings, this.topAbout });
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1008, 24);
            this.topMenu.TabIndex = 2;
            this.topMenu.Text = "Меню";
            // 
            // topFileMenu
            // 
            this.topFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.topFileMenuOpen, this.topFileMenuOpenLast, this.topFileMenuSplit });
            this.topFileMenu.Name = "topFileMenu";
            this.topFileMenu.Size = new System.Drawing.Size(48, 20);
            this.topFileMenu.Text = "Файл";
            // 
            // topFileMenuOpen
            // 
            this.topFileMenuOpen.Name = "topFileMenuOpen";
            this.topFileMenuOpen.Size = new System.Drawing.Size(224, 22);
            this.topFileMenuOpen.Text = "Открыть";
            this.topFileMenuOpen.Click += new System.EventHandler(this.TopFileMenuOpen_Click);
            // 
            // topFileMenuOpenLast
            // 
            this.topFileMenuOpenLast.Name = "topFileMenuOpenLast";
            this.topFileMenuOpenLast.Size = new System.Drawing.Size(224, 22);
            this.topFileMenuOpenLast.Text = "Открыть последнюю ленту";
            this.topFileMenuOpenLast.Click += new System.EventHandler(this.TopFileMenuOpenLast_Click);
            // 
            // topFileMenuSplit
            // 
            this.topFileMenuSplit.Name = "topFileMenuSplit";
            this.topFileMenuSplit.Size = new System.Drawing.Size(224, 22);
            this.topFileMenuSplit.Text = "Объеденить ленту";
            this.topFileMenuSplit.Click += new System.EventHandler(this.topFileMenuSplit_Click);
            // 
            // topOpenTableForm
            // 
            this.topOpenTableForm.Name = "topOpenTableForm";
            this.topOpenTableForm.Size = new System.Drawing.Size(134, 20);
            this.topOpenTableForm.Text = "Таблица параметров";
            this.topOpenTableForm.Click += new System.EventHandler(this.TopOpenTableForm_Click);
            // 
            // topDecoder
            // 
            this.topDecoder.Name = "topDecoder";
            this.topDecoder.Size = new System.Drawing.Size(123, 20);
            this.topDecoder.Text = "Авторасшифровка";
            this.topDecoder.Click += new System.EventHandler(this.topDecoder_Click);
            // 
            // topSettings
            // 
            this.topSettings.Name = "topSettings";
            this.topSettings.Size = new System.Drawing.Size(79, 20);
            this.topSettings.Text = "Настройки";
            this.topSettings.Click += new System.EventHandler(this.TopSettings_Click);
            // 
            // topAbout
            // 
            this.topAbout.Name = "topAbout";
            this.topAbout.Size = new System.Drawing.Size(94, 20);
            this.topAbout.Text = "О программе";
            this.topAbout.Click += new System.EventHandler(this.TopAbout_Click);
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.graphGroup);
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(0, 24);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.graphPanel.Size = new System.Drawing.Size(1008, 637);
            this.graphPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "MainForm";
            this.Text = "RTS - Просмотр ленты";
            this.graphGroup.ResumeLayout(false);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            this.graphPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView mainGraph;
        private System.Windows.Forms.GroupBox graphGroup;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem topFileMenu;
        private System.Windows.Forms.ToolStripMenuItem topFileMenuOpen;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.ToolStripMenuItem topOpenTableForm;
        private System.Windows.Forms.ToolStripMenuItem topAbout;
        private System.Windows.Forms.ToolStripMenuItem topSettings;
        private System.Windows.Forms.ToolStripMenuItem topFileMenuOpenLast;
        private System.Windows.Forms.ToolStripMenuItem topFileMenuSplit;
        private System.Windows.Forms.ToolStripMenuItem topDecoder;
    }
}

