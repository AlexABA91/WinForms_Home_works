namespace MoveWindow
{
    public partial class Form1 : Form
    {
        Rectangle vp;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
           
            vp = Screen.GetWorkingArea(Rectangle.Empty);
           
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            int speadPx = 50;

            if (Top == 0&& Left + Width != vp.Width) Left += speadPx;
            else if (Left == vp.Width - Width && Top != vp.Height - Height) Top += speadPx;
            else if (Top  == vp.Height - Height && Left !=0) Left -= speadPx;
            else if (Left == 0&& Top + Height != 0) Top -= speadPx;

            if(Top> vp.Height - Height) Top = vp.Height - Height;
            else if (Left > vp.Width - Width) Left = vp.Width - Width;
            else if (Top <0) Top = 0;
            else if (Left < 0) Left = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Left = 0;
                Top = 0;
                timer1.Start();
            }
            else if (e.KeyCode == Keys.Escape) timer1.Stop();
        }
    }
}