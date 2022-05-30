namespace MouseClickCounter
{
    public partial class Form1 : Form
    {
        int left, right, middle;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var fr = (Form)sender;

            switch (e.Button) {
                case MouseButtons.Left:
                   ++left;
                    break;
                case MouseButtons.Right:
                    ++right;
                    break;
                case MouseButtons.Middle:
                    ++middle;
                    break;
            }
            fr.Text = $"Left Button {left}, Middle Button {middle}, Right Button = {right}";
        }
    }
}