using System.Diagnostics;

namespace TagsOnMVP {
    public partial class FormView : Form, IView {

        List<Button> listButton;
        bool isEnabled = false;
        
        public (int, int) Swap { get; set; }
        public int CurrentTabIndex { get; set; }
        public int InRightPos { get; set; }

        public event EventHandler<EventArgs>? FieldButtonClick;
        public event EventHandler<EventArgs>? MixTransfer;

        Stopwatch watch;

        public FormView() {
            InitializeComponent();
            #region InitList
            listButton = new List<Button>();
            listButton.Add(button1);
            listButton.Add(button2);
            listButton.Add(button3);
            listButton.Add(button4);
            listButton.Add(button5);
            listButton.Add(button6);
            listButton.Add(button7);
            listButton.Add(button8);
            listButton.Add(button9);
            listButton.Add(button10);
            listButton.Add(button11);
            listButton.Add(button12);
            listButton.Add(button13);
            listButton.Add(button14);
            listButton.Add(button15);
            listButton.Add(button16);
            #endregion InitList
            watch = new Stopwatch();
        }
        private void New_game_Click(object sender, EventArgs e) {
            
            isEnabled = true;
            stopButton.Enabled = true;
            startButton.Enabled = false;

            toolStripStopButton.Enabled = true;
            Mix();
            ButtonEnabled();
            StarTImer(sender);
            ProgresBarChenger();
        }
        private void Buttons_clcki(object sender, EventArgs e) {
            var carentButton = sender as Button;
            if (carentButton != null) {
                CurrentTabIndex = carentButton.TabIndex;
                FieldButtonClick?.Invoke(this, EventArgs.Empty);
                WinChecker();
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            toolStripLabel1.Text = watch.Elapsed.ToString("mm\\:ss");
        }

        void ButtonEnabled() {
            if (!isEnabled) {
                foreach (var item in listButton)
                    item.Enabled = false;
            }
            else
                foreach (var item in listButton)
                    item.Enabled = true;
            button16.Enabled = false;
        }
        public void changeLocationButton() {

            var buttotoOldPos = listButton.Find(x => x.TabIndex == Swap.Item1);
            var buttotoNewPos = listButton.Find(x => x.TabIndex == Swap.Item2);

            if (buttotoOldPos != null && buttotoNewPos != null) {
                var temp = buttotoOldPos.Location;
                buttotoOldPos.Location = buttotoNewPos.Location;
                buttotoNewPos.Location = temp;
            }

        }
        void Mix() {
            MixTransfer?.Invoke(this, EventArgs.Empty);
        }


        void WinChecker() {
            
            ProgresBarChenger();
            if (InRightPos == listButton.Count-1) {
                StopGame();
                startButton.Enabled = false;
                toolStripStartButton.Enabled = false;
                stopButton.Enabled = false;
                toolStripStopButton.Enabled = false;
                toolStripStartButton.Checked = false;
                toolStripStopButton.Checked = false;
                MessageBox.Show("YOU WINNNNNNNNNNN!!!!!!!!!");
            }
        }
        void ProgresBarChenger() {
            toolStripProgressBar1.Maximum =listButton.Count-1;
            toolStripProgressBar1.Value = InRightPos;
        }

        void StarTImer(object sender) {
           if (sender == newGameButton|| sender == toolStripMenuNewGame) 
                watch.Restart();

            watch.Start();
            timer1.Start();
        }
        void StopGame() {
            isEnabled = false;
            ButtonEnabled();
            StopWatch();
        }
        void StopWatch() {
            watch.Stop();
            timer1.Stop();
        }

        private void startButtonClick(object sender, EventArgs e) {
            startButton.Enabled = false;
            toolStripStartButton.Checked = true;
            toolStripStartButton.Enabled = false;

            stopButton.Enabled = true;
            toolStripStopButton.Checked = false;
            toolStripStopButton.Enabled = true;
            isEnabled = true;
            ButtonEnabled();
            StarTImer(sender);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void StopButton_click(object sender, EventArgs e) {
            startButton.Enabled = true;
            toolStripStartButton.Checked = false;
            toolStripStartButton.Enabled = true;

            stopButton.Enabled = false;
            toolStripStopButton.Checked = true;
            toolStripStopButton.Enabled = false;
            isEnabled = false;
            ButtonEnabled();
            StopWatch();
        }

    }

}