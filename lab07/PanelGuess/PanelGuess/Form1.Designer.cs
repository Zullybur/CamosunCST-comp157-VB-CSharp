namespace PanelGuess
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lstbGridSize = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10pct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20pct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30pct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40pct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50pct = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumSpots = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Location = new System.Drawing.Point(8, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(196, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(3, 17);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(189, 429);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblScore);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.lblScoreTitle);
            this.groupBox2.Controls.Add(this.lstbGridSize);
            this.groupBox2.Location = new System.Drawing.Point(208, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(365, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(246, 38);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(167, 64);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(180, 15);
            this.lblScoreTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(152, 24);
            this.lblScoreTitle.TabIndex = 2;
            this.lblScoreTitle.Text = "Current Score: ";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstbGridSize
            // 
            this.lstbGridSize.FormattingEnabled = true;
            this.lstbGridSize.Items.AddRange(new object[] {
            "16 Squares (4 x 4)",
            "25 Squares (5 x 5)",
            "36 Squares (6 x 6)",
            "42 Squares (7 x 7)",
            "64 Squares (8 x 8)",
            "81 Squares (9 x 9)"});
            this.lstbGridSize.Location = new System.Drawing.Point(16, 17);
            this.lstbGridSize.Margin = new System.Windows.Forms.Padding(2);
            this.lstbGridSize.Name = "lstbGridSize";
            this.lstbGridSize.Size = new System.Drawing.Size(133, 82);
            this.lstbGridSize.TabIndex = 0;
            this.lstbGridSize.SelectedIndexChanged += new System.EventHandler(this.lbGridSize_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.selectionCountToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.difficultyToolStripMenuItem.Text = "&Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.DifficultyChangeHandler);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.DifficultyChangeHandler);
            // 
            // selectionCountToolStripMenuItem
            // 
            this.selectionCountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10pct,
            this.toolStripMenuItem20pct,
            this.toolStripMenuItem30pct,
            this.toolStripMenuItem40pct,
            this.toolStripMenuItem50pct});
            this.selectionCountToolStripMenuItem.Name = "selectionCountToolStripMenuItem";
            this.selectionCountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.selectionCountToolStripMenuItem.Text = "S&election Count";
            // 
            // toolStripMenuItem10pct
            // 
            this.toolStripMenuItem10pct.Name = "toolStripMenuItem10pct";
            this.toolStripMenuItem10pct.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem10pct.Text = "&10%";
            this.toolStripMenuItem10pct.Click += new System.EventHandler(this.PctSelectedHandler);
            // 
            // toolStripMenuItem20pct
            // 
            this.toolStripMenuItem20pct.Name = "toolStripMenuItem20pct";
            this.toolStripMenuItem20pct.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem20pct.Text = "&20%";
            this.toolStripMenuItem20pct.Click += new System.EventHandler(this.PctSelectedHandler);
            // 
            // toolStripMenuItem30pct
            // 
            this.toolStripMenuItem30pct.Name = "toolStripMenuItem30pct";
            this.toolStripMenuItem30pct.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem30pct.Text = "&30%";
            this.toolStripMenuItem30pct.Click += new System.EventHandler(this.PctSelectedHandler);
            // 
            // toolStripMenuItem40pct
            // 
            this.toolStripMenuItem40pct.Name = "toolStripMenuItem40pct";
            this.toolStripMenuItem40pct.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem40pct.Text = "&40%";
            this.toolStripMenuItem40pct.Click += new System.EventHandler(this.PctSelectedHandler);
            // 
            // toolStripMenuItem50pct
            // 
            this.toolStripMenuItem50pct.Name = "toolStripMenuItem50pct";
            this.toolStripMenuItem50pct.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem50pct.Text = "&50%";
            this.toolStripMenuItem50pct.Click += new System.EventHandler(this.PctSelectedHandler);
            // 
            // lblNumSpots
            // 
            this.lblNumSpots.AutoSize = true;
            this.lblNumSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSpots.Location = new System.Drawing.Point(335, 30);
            this.lblNumSpots.Name = "lblNumSpots";
            this.lblNumSpots.Size = new System.Drawing.Size(130, 16);
            this.lblNumSpots.TabIndex = 3;
            this.lblNumSpots.Text = "Panels to Select : XX";
            this.lblNumSpots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(266, 347);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(111, 23);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.PlayAgainHandler);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 484);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblNumSpots);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 523);
            this.MinimumSize = new System.Drawing.Size(600, 523);
            this.Name = "Form1";
            this.Text = "Panel Guess";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.ListBox lstbGridSize;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10pct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20pct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30pct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40pct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50pct;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Label lblNumSpots;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

