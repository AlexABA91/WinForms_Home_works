namespace BooksAndAuthor {
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSeve = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAutorAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAutorDelet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuBookAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuBookDelet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuBookEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Tan;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(18, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(576, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuOpenButton,
            this.toolStripMenuSeve,
            this.toolStripExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "&Файл";
            // 
            // toolStripMenuOpenButton
            // 
            this.toolStripMenuOpenButton.Name = "toolStripMenuOpenButton";
            this.toolStripMenuOpenButton.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuOpenButton.Text = "&Открыть";
            this.toolStripMenuOpenButton.Click += new System.EventHandler(this.toolStripMenuOpenButton_Click);
            // 
            // toolStripMenuSeve
            // 
            this.toolStripMenuSeve.Name = "toolStripMenuSeve";
            this.toolStripMenuSeve.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuSeve.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuSeve.Text = "&Сохранить";
            this.toolStripMenuSeve.Click += new System.EventHandler(this.toolStripMenuSeve_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripExit.Size = new System.Drawing.Size(173, 22);
            this.toolStripExit.Text = "&Выход";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAutorAdd,
            this.toolStripMenuAutorDelet,
            this.toolStripMenuEditAutor,
            this.toolStripMenuBookAdd,
            this.toolStripMenuBookDelet,
            this.toolStripMenuBookEdit});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem4.Text = "Опции";
            // 
            // toolStripMenuAutorAdd
            // 
            this.toolStripMenuAutorAdd.Name = "toolStripMenuAutorAdd";
            this.toolStripMenuAutorAdd.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuAutorAdd.Text = "Добавить Автора";
            this.toolStripMenuAutorAdd.Click += new System.EventHandler(this.ClickOptionButton);
            // 
            // toolStripMenuAutorDelet
            // 
            this.toolStripMenuAutorDelet.Name = "toolStripMenuAutorDelet";
            this.toolStripMenuAutorDelet.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuAutorDelet.Text = "Удалить Автора";
            this.toolStripMenuAutorDelet.Click += new System.EventHandler(this.ClickOptionButton);
            // 
            // toolStripMenuEditAutor
            // 
            this.toolStripMenuEditAutor.Name = "toolStripMenuEditAutor";
            this.toolStripMenuEditAutor.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuEditAutor.Text = "Редактировать Автора";
            this.toolStripMenuEditAutor.Click += new System.EventHandler(this.ClickOptionButton);
            // 
            // toolStripMenuBookAdd
            // 
            this.toolStripMenuBookAdd.Name = "toolStripMenuBookAdd";
            this.toolStripMenuBookAdd.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuBookAdd.Text = "Добавить Книгу ";
            this.toolStripMenuBookAdd.Click += new System.EventHandler(this.ClickOptionButton);
            // 
            // toolStripMenuBookDelet
            // 
            this.toolStripMenuBookDelet.Name = "toolStripMenuBookDelet";
            this.toolStripMenuBookDelet.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuBookDelet.Text = "Удалить Книгу ";
            this.toolStripMenuBookDelet.Click += new System.EventHandler(this.ClickOptionButton);
            // 
            // toolStripMenuBookEdit
            // 
            this.toolStripMenuBookEdit.Name = "toolStripMenuBookEdit";
            this.toolStripMenuBookEdit.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuBookEdit.Text = "Редактировать Книгу";
            this.toolStripMenuBookEdit.Click += new System.EventHandler(this.ClickOptionButton);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "File.json";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "File.json";
            this.saveFileDialog1.Filter = "File |*.json| All File |*.* ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(184, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 41);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Фильтрация";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Tan;
            this.listBox1.Font = new System.Drawing.Font("a_FuturicaLt", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(18, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 158);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Авторы и книги ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuOpenButton;
        private ToolStripMenuItem toolStripMenuSeve;
        private ToolStripMenuItem toolStripExit;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuAutorAdd;
        private ToolStripMenuItem toolStripMenuAutorDelet;
        private ToolStripMenuItem toolStripMenuEditAutor;
        private ToolStripMenuItem toolStripMenuBookAdd;
        private ToolStripMenuItem toolStripMenuBookDelet;
        private ToolStripMenuItem toolStripMenuBookEdit;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private CheckBox checkBox1;
        private ListBox listBox1;
    }
}