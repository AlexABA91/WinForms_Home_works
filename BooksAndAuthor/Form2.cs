using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAndAuthor {
    public partial class Form2 : Form {
        public Form MainForm { get; set; }

        public string TextBox {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Form2(string labelText) {
            InitializeComponent();
            label1.Text = labelText;
        }
    }
}
