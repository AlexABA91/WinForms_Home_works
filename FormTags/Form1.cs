using System.Diagnostics;

namespace FormTags {
    public partial class Form1 : Form {
        const int FS = 4;
        const int WIN = FS * FS - 1;
        List<Button> listButton;
        int[,] arrField;
        Stopwatch watch;

        enum movederection : int { UP = 0, LEFT, DOWN, RIGHT }
        bool isEnabled = false;

        public Form1() {
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
            arrField = new int[FS, FS];
            watch = new Stopwatch();
            IntiArr();
        }

        private void New_game_Click(object sender, EventArgs e) {
            isEnabled = true;
            stopButton.Enabled = true;
            toolStripStopButton.Enabled = true;
           
            Mixer(0, 100, (FS - 1, FS - 1));
            ButtonEnabled();
            
            StarTImer(sender);

            ProgresBarChenger(RightPositionCheckr());
        }
        private void Buttons_clcki(object sender, EventArgs e) {
            var posInArr = GetPositionInArr(sender);
            if (TryChange(posInArr)) {
                WinChecker();
            };
        }
        private void timer1_Tick(object sender, EventArgs e) {
            toolStripLabel1.Text = watch.Elapsed.ToString("mm\\:ss");
        }

        void IntiArr() {
            Array.Clear(arrField);
            
            int index = 0;
            for (int i = 0; i < FS; i++) {
                for (int j = 0; j < FS; index++, j++) {
                    arrField[i, j] = listButton[index].TabIndex;
                    
                }
            }
        }
        
        int Mixer(int moveSite, int mixStepCount, (int y, int x) posInArr) {

            if (mixStepCount == 0) return mixStepCount;

            Random r = new Random();
            moveSite = r.Next(0, 4);

            switch ((movederection)moveSite) {
                case movederection.UP:
                    var (y, x) = posInArr;
                    if (!(y - 1 < 0)) {
                        var newPosInArr = (y - 1, x);
                        PositionSwop(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;

                case movederection.LEFT:
                    (y, x) = posInArr;
                    if (!(x + 1 > FS - 1)) {
                        var newPosInArr = (y, x + 1);
                        PositionSwop(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;
                case movederection.DOWN:
                    (y, x) = posInArr;
                    if (!(y + 1 > FS - 1)) {
                        var newPosInArr = (y + 1, x);
                        PositionSwop(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;
                case movederection.RIGHT:
                    (y, x) = posInArr;
                    if (!(x - 1 < 0)) {
                        var newPosInArr = (y, x - 1);
                        PositionSwop(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;
            }
            Mixer(moveSite, mixStepCount, posInArr);
            return 0;
        }
        void PositionSwop((int y, int x) posInArr, (int y, int x) newPosInArr) {
            var oldPos = arrField[posInArr.y, posInArr.x];
            var newPos = arrField[newPosInArr.y, newPosInArr.x];

            var buttotoOldPos = listButton.Find(x => x.TabIndex == oldPos);
            var buttotoNewPos = listButton.Find(x => x.TabIndex == newPos);

            if (buttotoOldPos != null && buttotoNewPos != null) {
                var temp = buttotoOldPos.Location;
                buttotoOldPos.Location = buttotoNewPos.Location;
                buttotoNewPos.Location = temp;

                arrField[posInArr.y, posInArr.x] = newPos;
                arrField[newPosInArr.y, newPosInArr.x] = oldPos;
            }

        }
        (int, int) GetPositionInArr(object sender) {
            var carentButton = sender as Button;
            if (carentButton != null) {
                for (int i = 0; i < FS; i++)
                    for (int j = 0; j < FS; j++) {
                        if (arrField[i, j] == carentButton.TabIndex) {
                            return (i, j);
                        }
                    }
            }
            throw new ArgumentNullException("Button is Null", nameof(carentButton));
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
        bool TryChange((int y, int x) t) {

            var (y, x) = t;
            if (y - 1 >= 0)
                if (arrField[y - 1, x] == 0) {
                    var newPosInArr = (y - 1, x);
                    PositionSwop(t, newPosInArr);
                    return true;
                }

            if (y + 1 < FS)
                if (arrField[y + 1, x] == 0) {
                    var newPosInArr = (y + 1, x);
                    PositionSwop(t, newPosInArr);
                    return true;
                }

            if (x - 1 >= 0)
                if (arrField[y, x - 1] == 0) {
                    var newPosInArr = (y, x - 1);
                    PositionSwop(t, newPosInArr);
                    return true;
                }

            if (x + 1 < FS)
                if (arrField[y, x + 1] == 0) {
                    var newPosInArr = (y, x + 1);
                    PositionSwop(t, newPosInArr);
                    return true;
                }
            return false;
        }
        int RightPositionCheckr() {
            int count = 0;
            int index = 1; ;
            for (int i = 0; i < FS; ++i)
                for (int j = 0; j < FS; ++index, ++j) {
                    if (arrField[i, j] == index)
                        ++count;
                }
            if (count == WIN) {
                return WIN;
            }
            else return count;
        }
        void WinChecker() {
            int inRigtPositin = RightPositionCheckr();
            ProgresBarChenger(inRigtPositin);
            if (inRigtPositin == WIN) {
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
        void ProgresBarChenger(int win) {
            toolStripProgressBar1.Maximum = FS * FS - 1;
            toolStripProgressBar1.Value = win;
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