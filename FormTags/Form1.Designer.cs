namespace FormTags {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newGameButton = new System.Windows.Forms.ToolStripButton();
            this.startButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameButton,
            this.startButton,
            this.stopButton,
            this.toolStripLabel1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newGameButton
            // 
            this.newGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newGameButton.Image = global::FormTags.Properties.Resources.icons8_nginx_accelerates_content_and_application_delivery_improves_security_30;
            this.newGameButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newGameButton.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(34, 34);
            this.newGameButton.Text = "New Game ";
            this.newGameButton.Click += new System.EventHandler(this.New_game_Click);
            // 
            // startButton
            // 
            this.startButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Image = global::FormTags.Properties.Resources.icons8_начало_30;
            this.startButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.startButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.startButton.Size = new System.Drawing.Size(49, 34);
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Enabled = false;
            this.stopButton.Image = global::FormTags.Properties.Resources.icons8_пауза_в_квадрате_30;
            this.stopButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.stopButton.Size = new System.Drawing.Size(49, 34);
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.StopButton_click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 34);
            this.toolStripLabel1.Text = "00:00";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(255, 34);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuNewGame,
            this.toolStripStartButton,
            this.toolStripStopButton,
            this.exitToolStripMenuExit});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenu.Text = "&Menu";
            // 
            // toolStripMenuNewGame
            // 
            this.toolStripMenuNewGame.Name = "toolStripMenuNewGame";
            this.toolStripMenuNewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuNewGame.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuNewGame.Text = "New Game";
            this.toolStripMenuNewGame.Click += new System.EventHandler(this.New_game_Click);
            // 
            // toolStripStartButton
            // 
            this.toolStripStartButton.Enabled = false;
            this.toolStripStartButton.Name = "toolStripStartButton";
            this.toolStripStartButton.Size = new System.Drawing.Size(180, 22);
            this.toolStripStartButton.Text = "&START";
            this.toolStripStartButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // toolStripStopButton
            // 
            this.toolStripStopButton.Enabled = false;
            this.toolStripStopButton.Name = "toolStripStopButton";
            this.toolStripStopButton.Size = new System.Drawing.Size(180, 22);
            this.toolStripStopButton.Text = "S&TOP";
            this.toolStripStopButton.Click += new System.EventHandler(this.StopButton_click);
            // 
            // exitToolStripMenuExit
            // 
            this.exitToolStripMenuExit.Name = "exitToolStripMenuExit";
            this.exitToolStripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuExit.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuExit.Text = "&Exit";
            this.exitToolStripMenuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 366);
            this.panel1.TabIndex = 3;
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button13.Enabled = false;
            this.button13.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.Red;
            this.button13.Location = new System.Drawing.Point(1, 267);
            this.button13.Margin = new System.Windows.Forms.Padding(1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(106, 90);
            this.button13.TabIndex = 13;
            this.button13.Tag = "13";
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(106, 267);
            this.button14.Margin = new System.Windows.Forms.Padding(1);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(106, 90);
            this.button14.TabIndex = 14;
            this.button14.Tag = "14";
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button15
            // 
            this.button15.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.Red;
            this.button15.Location = new System.Drawing.Point(211, 267);
            this.button15.Margin = new System.Windows.Forms.Padding(1);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(106, 90);
            this.button15.TabIndex = 15;
            this.button15.Tag = "15";
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(316, 267);
            this.button16.Margin = new System.Windows.Forms.Padding(1);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(106, 90);
            this.button16.TabIndex = 0;
            this.button16.Tag = "0";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(1, 178);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 90);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(106, 178);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 90);
            this.button10.TabIndex = 10;
            this.button10.Tag = "10";
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button11.Enabled = false;
            this.button11.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(211, 178);
            this.button11.Margin = new System.Windows.Forms.Padding(1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(106, 90);
            this.button11.TabIndex = 11;
            this.button11.Tag = "11";
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(316, 178);
            this.button12.Margin = new System.Windows.Forms.Padding(1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(106, 90);
            this.button12.TabIndex = 12;
            this.button12.Tag = "12";
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1, 90);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 90);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(106, 90);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 90);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(211, 90);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 90);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(316, 90);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 90);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(316, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 90);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(211, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 90);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(106, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 90);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FormTags.Properties.Resources.till;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 90);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Buttons_clcki);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(451, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TAGS";
            this.Click += new System.EventHandler(this.startButtonClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private ToolStripButton startButton;
        private ToolStripButton stopButton;
        private ToolStripLabel toolStripLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenu;
        private ToolStripMenuItem toolStripStartButton;
        private ToolStripMenuItem toolStripStopButton;
        private ToolStripMenuItem exitToolStripMenuExit;
        private ToolTip toolTip1;
        private ToolStripMenuItem toolStripMenuNewGame;
        private Panel panel1;
        private ToolStripButton newGameButton;
        private Button button1;
        private Button button2;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button4;
        private Button button3;
        private Button button13;
    }
}