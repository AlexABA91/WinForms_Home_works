namespace BooksAndAuthor {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKButton1 = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Tan;
            this.textBox1.Location = new System.Drawing.Point(6, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 23);
            this.textBox1.TabIndex = 1;
            // 
            // OKButton1
            // 
            this.OKButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OKButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.OKButton1.Location = new System.Drawing.Point(26, 118);
            this.OKButton1.Name = "OKButton1";
            this.OKButton1.Size = new System.Drawing.Size(100, 30);
            this.OKButton1.TabIndex = 2;
            this.OKButton1.Text = "OK";
            this.OKButton1.UseVisualStyleBackColor = false;
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CanselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanselButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CanselButton.Location = new System.Drawing.Point(216, 118);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(100, 30);
            this.CanselButton.TabIndex = 3;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(337, 160);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.OKButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button OKButton1;
        private Button CanselButton;
    }
}