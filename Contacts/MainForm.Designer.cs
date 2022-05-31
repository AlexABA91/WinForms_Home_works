namespace Contacts {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRewride = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.plus = new System.Windows.Forms.ToolStripButton();
            this.minus = new System.Windows.Forms.ToolStripButton();
            this.rewrite = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Info = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Bisque;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPlus,
            this.toolStripMinus,
            this.toolStripRewride,
            this.toolStripInfo,
            this.toolStripExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(1, 0, 4, 0);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // toolStripPlus
            // 
            this.toolStripPlus.Name = "toolStripPlus";
            this.toolStripPlus.Size = new System.Drawing.Size(182, 22);
            this.toolStripPlus.Text = "Добавить Контакт...";
            this.toolStripPlus.Click += new System.EventHandler(this.plus_Click);
            // 
            // toolStripMinus
            // 
            this.toolStripMinus.Name = "toolStripMinus";
            this.toolStripMinus.Size = new System.Drawing.Size(182, 22);
            this.toolStripMinus.Text = "Удалить Контакт";
            this.toolStripMinus.Click += new System.EventHandler(this.minus_Click);
            // 
            // toolStripRewride
            // 
            this.toolStripRewride.Name = "toolStripRewride";
            this.toolStripRewride.Size = new System.Drawing.Size(182, 22);
            this.toolStripRewride.Text = "Изменить контакт...";
            this.toolStripRewride.Click += new System.EventHandler(this.rewrite_Click);
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(182, 22);
            this.toolStripInfo.Text = "Информация...";
            this.toolStripInfo.Click += new System.EventHandler(this.Info_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripExit.Size = new System.Drawing.Size(182, 22);
            this.toolStripExit.Text = "Выход";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(584, 289);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plus,
            this.minus,
            this.rewrite,
            this.toolStripSeparator1,
            this.Info});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // plus
            // 
            this.plus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plus.Image = global::Contacts.Properties.Resources.plus;
            this.plus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(23, 36);
            this.plus.Text = "Добавить контакт";
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minus.Image = global::Contacts.Properties.Resources.minus;
            this.minus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(23, 36);
            this.minus.Text = "Удалить контакт";
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // rewrite
            // 
            this.rewrite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rewrite.Image = global::Contacts.Properties.Resources.penci;
            this.rewrite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rewrite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rewrite.Name = "rewrite";
            this.rewrite.Size = new System.Drawing.Size(36, 36);
            this.rewrite.Text = "Редактировать Контакт";
            this.rewrite.Click += new System.EventHandler(this.rewrite_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Info
            // 
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Info.Image = global::Contacts.Properties.Resources.sign;
            this.Info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(36, 36);
            this.Info.Text = "Показать всю инфармацию";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Контакты ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripPlus;
        private ToolStripMenuItem toolStripMinus;
        private ToolStripMenuItem toolStripRewride;
        private ToolStripMenuItem toolStripInfo;
        private ToolStripMenuItem toolStripExit;
        private ListBox listBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton plus;
        private ToolStripButton minus;
        private ToolStripButton rewrite;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Info;
    }
}