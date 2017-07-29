namespace game1
{
    partial class MainForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.arrowKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.startGroupBox = new System.Windows.Forms.GroupBox();
            this.goButton = new System.Windows.Forms.Button();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.lableComboBox = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyPictureBox4 = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox3 = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox2 = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox1 = new System.Windows.Forms.PictureBox();
            this.targetPictureBox = new System.Windows.Forms.PictureBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.topButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.arrowKeyGroupBox.SuspendLayout();
            this.startGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopPanel.Controls.Add(this.arrowKeyGroupBox);
            this.TopPanel.Controls.Add(this.startGroupBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 24);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(559, 112);
            this.TopPanel.TabIndex = 0;
            // 
            // arrowKeyGroupBox
            // 
            this.arrowKeyGroupBox.Controls.Add(this.leftButton);
            this.arrowKeyGroupBox.Controls.Add(this.downButton);
            this.arrowKeyGroupBox.Controls.Add(this.topButton);
            this.arrowKeyGroupBox.Controls.Add(this.rightButton);
            this.arrowKeyGroupBox.Location = new System.Drawing.Point(398, 3);
            this.arrowKeyGroupBox.Name = "arrowKeyGroupBox";
            this.arrowKeyGroupBox.Size = new System.Drawing.Size(149, 103);
            this.arrowKeyGroupBox.TabIndex = 3;
            this.arrowKeyGroupBox.TabStop = false;
            // 
            // startGroupBox
            // 
            this.startGroupBox.Controls.Add(this.goButton);
            this.startGroupBox.Controls.Add(this.levelComboBox);
            this.startGroupBox.Controls.Add(this.lableComboBox);
            this.startGroupBox.Location = new System.Drawing.Point(23, 12);
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.Size = new System.Drawing.Size(196, 94);
            this.startGroupBox.TabIndex = 7;
            this.startGroupBox.TabStop = false;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.goButton.ForeColor = System.Drawing.Color.Orange;
            this.goButton.Location = new System.Drawing.Point(138, 35);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(38, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "4",
            "3",
            "2",
            "1"});
            this.levelComboBox.Location = new System.Drawing.Point(78, 37);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(48, 21);
            this.levelComboBox.TabIndex = 1;
            this.levelComboBox.Text = "1";
            this.levelComboBox.SelectedIndexChanged += new System.EventHandler(this.levelComboBox_SelectedIndexChanged);
            // 
            // lableComboBox
            // 
            this.lableComboBox.AutoSize = true;
            this.lableComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lableComboBox.ForeColor = System.Drawing.Color.Gold;
            this.lableComboBox.Location = new System.Drawing.Point(16, 35);
            this.lableComboBox.Name = "lableComboBox";
            this.lableComboBox.Size = new System.Drawing.Size(56, 20);
            this.lableComboBox.TabIndex = 0;
            this.lableComboBox.Text = "Level:";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.mainPanel.Controls.Add(this.enemyPictureBox4);
            this.mainPanel.Controls.Add(this.enemyPictureBox3);
            this.mainPanel.Controls.Add(this.enemyPictureBox2);
            this.mainPanel.Controls.Add(this.enemyPictureBox1);
            this.mainPanel.Controls.Add(this.targetPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 136);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(559, 332);
            this.mainPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // enemyPictureBox4
            // 
            this.enemyPictureBox4.BackColor = System.Drawing.Color.Navy;
            this.enemyPictureBox4.Location = new System.Drawing.Point(264, 157);
            this.enemyPictureBox4.Name = "enemyPictureBox4";
            this.enemyPictureBox4.Size = new System.Drawing.Size(30, 30);
            this.enemyPictureBox4.TabIndex = 11;
            this.enemyPictureBox4.TabStop = false;
            this.enemyPictureBox4.Visible = false;
            // 
            // enemyPictureBox3
            // 
            this.enemyPictureBox3.BackColor = System.Drawing.Color.Navy;
            this.enemyPictureBox3.Location = new System.Drawing.Point(23, 163);
            this.enemyPictureBox3.Name = "enemyPictureBox3";
            this.enemyPictureBox3.Size = new System.Drawing.Size(30, 30);
            this.enemyPictureBox3.TabIndex = 10;
            this.enemyPictureBox3.TabStop = false;
            this.enemyPictureBox3.Visible = false;
            // 
            // enemyPictureBox2
            // 
            this.enemyPictureBox2.BackColor = System.Drawing.Color.Navy;
            this.enemyPictureBox2.Location = new System.Drawing.Point(264, 18);
            this.enemyPictureBox2.Name = "enemyPictureBox2";
            this.enemyPictureBox2.Size = new System.Drawing.Size(30, 30);
            this.enemyPictureBox2.TabIndex = 9;
            this.enemyPictureBox2.TabStop = false;
            this.enemyPictureBox2.Visible = false;
            // 
            // enemyPictureBox1
            // 
            this.enemyPictureBox1.BackColor = System.Drawing.Color.Navy;
            this.enemyPictureBox1.Location = new System.Drawing.Point(0, 18);
            this.enemyPictureBox1.Name = "enemyPictureBox1";
            this.enemyPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.enemyPictureBox1.TabIndex = 8;
            this.enemyPictureBox1.TabStop = false;
            // 
            // targetPictureBox
            // 
            this.targetPictureBox.BackColor = System.Drawing.Color.Azure;
            this.targetPictureBox.Location = new System.Drawing.Point(161, 89);
            this.targetPictureBox.Name = "targetPictureBox";
            this.targetPictureBox.Size = new System.Drawing.Size(30, 30);
            this.targetPictureBox.TabIndex = 7;
            this.targetPictureBox.TabStop = false;
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftButton.AutoSize = true;
            this.leftButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.leftButton.Image = global::game1.Properties.Resources.leftImage;
            this.leftButton.Location = new System.Drawing.Point(6, 55);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(46, 46);
            this.leftButton.TabIndex = 3;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.button_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.AutoSize = true;
            this.downButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.downButton.Image = global::game1.Properties.Resources.downImage_;
            this.downButton.Location = new System.Drawing.Point(52, 55);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(46, 46);
            this.downButton.TabIndex = 6;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.button_Click);
            // 
            // topButton
            // 
            this.topButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topButton.AutoSize = true;
            this.topButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.topButton.Image = global::game1.Properties.Resources.upImage;
            this.topButton.Location = new System.Drawing.Point(52, 9);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(46, 46);
            this.topButton.TabIndex = 4;
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.button_Click);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.AutoSize = true;
            this.rightButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.rightButton.Image = global::game1.Properties.Resources.rightImage;
            this.rightButton.Location = new System.Drawing.Point(97, 55);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(46, 46);
            this.rightButton.TabIndex = 5;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.button_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 468);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.arrowKeyGroupBox.ResumeLayout(false);
            this.arrowKeyGroupBox.PerformLayout();
            this.startGroupBox.ResumeLayout(false);
            this.startGroupBox.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label lableComboBox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.PictureBox enemyPictureBox2;
        private System.Windows.Forms.PictureBox enemyPictureBox1;
        private System.Windows.Forms.PictureBox targetPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox enemyPictureBox4;
        private System.Windows.Forms.PictureBox enemyPictureBox3;
        private System.Windows.Forms.GroupBox startGroupBox;
        private System.Windows.Forms.GroupBox arrowKeyGroupBox;
    }
}

