
namespace XandO {
    public partial class Form1 : Form {
        const int FL = 3;
        List<Button> feildButtons;
        char[,] arr;
        int moveCount;

        Image o = Properties.Resources.O;
        Image x = Properties.Resources.x;
        char player;
        char cpu;
        

        public Form1() {
            InitializeComponent();
          
            feildButtons = new List<Button>();
            arr = new char[3, FL];
            #region addToList; 
            feildButtons.Add(button1);
            feildButtons.Add(button2);
            feildButtons.Add(button3);
            feildButtons.Add(button4);
            feildButtons.Add(button5);
            feildButtons.Add(button6);
            feildButtons.Add(button7);
            feildButtons.Add(button8);
            feildButtons.Add(button9);
            # endregion AddToList

            foreach (var item in feildButtons) {
                item.Tag = ' ';
            }
          

        }

        private void button10_Click(object sender, EventArgs? e) {
            FeildClean();
            
            if (checkBox1.Checked) {
                player = 'o';
                cpu = 'x';
            }
            else {
                player = 'x';
                cpu = 'o';
            }

            foreach (var item in feildButtons) {
                item.Enabled = true;
            }
            if (checkBox1.Checked)
                CpuMove();
        }
        private void PlayerClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (sender is Button button) {
                    if ((Convert.ToChar(button.Tag.ToString()!) == ' ')) {
                        button.Tag = player;
                        button.BackgroundImage = player =='x'?x:o;
                        button.Enabled = false;
                        ++moveCount;
                        initArr();
                        if (Win() == false) {
                            CpuMove();
                        };
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Stop();

            foreach (var item in feildButtons) {
                item.Enabled = true;
            }

            if (radioButton1.Checked) DumpLogic();
            else if (radioButton2.Checked) SmartLogic();
            ++moveCount;
            Win();
        }

        private void CpuMove() {
            foreach (var item in feildButtons) {
                item.Enabled = false;
            }
            timer1.Start();
        }
        private void DumpLogic() {
            Random r = new Random();

            var rFri = new List<int>();
            foreach (var item in feildButtons)
                if (Convert.ToChar(item.Tag.ToString()!) == ' ')
                    rFri.Add(feildButtons.IndexOf(item));

            if (rFri != null) {
                int num = r.Next(0, rFri.Count);
                feildButtons[rFri[num]].Tag = cpu;
                feildButtons[rFri[num]].BackgroundImage = cpu == 'o'?o:x;
                initArr();
            }
        }
        private void SmartLogic() {

            var bestScore = int.MinValue;
            var bestMuve = (0, 0);
            for (int i = 0; i < FL; ++i)
                for (int j = 0; j < FL; ++j) {
                    if (arr[i, j] == ' ') {
                        arr[i, j] = cpu;
                        var score = minimax(arr, 0, false);
                        arr[i, j] = ' ';
                        if (score > bestScore) {
                            bestScore = score;
                            bestMuve = (i, j);
                        }
                    }
                }
            arr[bestMuve.Item1, bestMuve.Item2] = cpu;

            var index = indexOf(bestMuve);
            feildButtons[index].Tag = cpu;
            feildButtons[index].BackgroundImage = cpu == 'o' ? o : x;
            initArr();
        }
        int minimax(char[,] arrCopy, int dept, bool isMaximizing) {

            var resolt = WinControle();

            if (resolt != 0)
                return resolt;

            if (isMaximizing) {
                var bestScore = int.MaxValue;
                for (int i = 0; i < FL; ++i) {
                    for (int j = 0; j < FL; ++j) {
                        if (arrCopy[i, j] == ' ') {
                            arrCopy[i, j] = cpu;
                            var score = minimax(arrCopy, +1, false);
                            arrCopy[i, j] = ' ';
                            bestScore = Math.Max(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
            else {
                var bestScore = int.MaxValue;
                for (int i = 0; i < FL; ++i) {
                    for (int j = 0; j < FL; ++j) {
                        if (arrCopy[i, j] == ' ') {
                            arrCopy[i, j] = player;
                            var score = minimax(arrCopy, +1, true);
                            arrCopy[i, j] = ' ';
                            bestScore = Math.Min(score, bestScore);
                        }
                    }
                }
                return bestScore;
            }
        }
        int indexOf((int, int) t) {
            int index = 0;
            if (t.Item1 == 0 && t.Item2 == 0) return index;
            {
                for (int i = 0; i < FL; i++) {
                    for (int j = 0; j < FL; j++) {
                        index++;
                        if (t.Item2 == j && t.Item1 == i) break;

                    }
                    if (t.Item1 == i) break;
                }
            }
            return index - 1;
        }

        private void initArr() {
            int counter = 0;
            for (int i = 0; i < FL; i++)
                for (int j = 0; j < FL; counter++, j++)
                    if (Convert.ToChar(feildButtons[counter].Tag.ToString()!) != ' ')
                        arr[i, j] = Convert.ToChar(feildButtons[counter].Tag.ToString()!);
        }
        private void FeildClean() {
            moveCount = 0;
            foreach (var item in feildButtons) {
                item.BackgroundImage = default;
                item.Enabled = false;
                item.Tag = ' ';
            }
            for (int i = 0; i < FL; i++)
                for (int j = 0; j < FL; j++)
                    arr[i, j] = ' ';
        }
        private int WinControle() {

            int resolt = Ver();
            if (resolt == 0) resolt = DioOne();
            if (resolt == 0) resolt = DioTwo();
            if (resolt == 0) resolt = Par();
            return resolt;
        }

        bool Win() {
            if (moveCount > FL+2) {
                int v = WinControle();
                if (v == 1) {
                    MessageBox.Show("Вы Выграли", "Победа", MessageBoxButtons.OK);
                    FeildClean();
                    button10_Click(this, null);
                    return true;
                }
                else if (v == -1) {
                    MessageBox.Show("Вы Проиграли", "Поражение", MessageBoxButtons.OK);
                    FeildClean();
                    button10_Click(this, null);
                    return true;
                }
                else if (moveCount == FL*FL) {
                    MessageBox.Show("Ничья", "Тю!!!", MessageBoxButtons.OK);
                    FeildClean();
                    button10_Click(this, null);
                    return true;
                }
            }
            return false;
        }
        #region WinChecker
        int Ver() {
            int x = 0;
            int o = 0;
            int vinSum = FL;
            for (int i = 0; i < vinSum; i++) {
                x = 0;
                o = 0;
                for (int j = 0; j < vinSum; j++) {
                    if (arr[i, j] == 'x') x++;
                    if (arr[i, j] == 'o') o++;
                }
                if (x == vinSum) break;
                if (o == vinSum) break;
            }
            if (x == vinSum) return 1;
            else if (o == vinSum) return -1;
            else return 0;
        }
        int Par() {
            int x = 0;
            int o = 0;
            int vinSum = FL;

            for (int i = 0; i < vinSum; i++) {
                x = 0;
                o = 0;
                for (int j = 0; j < vinSum; j++) {
                    if (arr[j, i] == 'x') x++;
                    if (arr[j, i] == 'o') o++;
                }
                if (x == vinSum) break;
                if (o == vinSum) break;
            }
            if (x == vinSum) return 1;
            else if (o == vinSum) return -1;
            else return 0;

        }
        int DioOne() {


            int x = 0;
            int o = 0;
            int vinSum = FL;
            for (int i = 0; i < FL; i++) {
                if (arr[i, i] == 'x') x++;
                if (arr[i, i] == 'o') o++;
            }
            if (x == vinSum) return 1;
            else if (o == vinSum) return -1;
            else return 0;
        }
        int DioTwo() {
            int x = 0;
            int o = 0;
            int vinSum = FL;
            for (int i = 0; i < FL; i++) {
                if (arr[FL - i - 1, i] == 'x') x++;
                else if (arr[FL - i - 1, i] == 'o') o++;
            }
            if (x == vinSum) return 1;
            else if (o == vinSum) return -1;
            else return 0;
        }

        #endregion WinCheker

        #region toolStrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            if (toolStripMenuItem4.Checked) checkBox1.Checked = true;
            else checkBox1.Checked = false;
        }
        private void checkBox1_Click(object sender, EventArgs e) {
            if (checkBox1.Checked == true) {
                toolStripMenuItem4.Checked = false;
                checkBox1.Checked = false;
            }
            else {
                toolStripMenuItem4.Checked = true;
                checkBox1.Checked = true;
            }
        }
        private void toolStripMenuDiff_Click(object sender, EventArgs e) {
            if (toolStripMenuItem2 == sender as ToolStripMenuItem) {
                _ = toolStripMenuItem2.Checked == true ?
                     toolStripMenuItem2.Checked = false : toolStripMenuItem2.Checked = true;
                radioButton1.Checked = toolStripMenuItem2.Checked;
                radioButton2.Checked = !radioButton1.Checked;
                toolStripMenuItem3.Checked = !toolStripMenuItem2.Checked;
            }
            else if (toolStripMenuItem3 == sender as ToolStripMenuItem) {
                _ = toolStripMenuItem3.Checked == true ?
                        toolStripMenuItem3.Checked = false : toolStripMenuItem3.Checked = true;
                radioButton2.Checked = toolStripMenuItem3.Checked;
                radioButton1.Checked = !radioButton2.Checked;
                toolStripMenuItem2.Checked = !toolStripMenuItem3.Checked;
            }
        }
        private void radioButton2_Click(object sender, EventArgs e) {
            if (radioButton1 == sender as RadioButton || radioButton1.Checked != true) {
                radioButton1.Checked = !radioButton2.Checked;
                radioButton2.Checked = !radioButton1.Checked;
                toolStripMenuItem2.Checked = radioButton1.Checked;
                toolStripMenuItem3.Checked = !toolStripMenuItem2.Checked;
            }
            else if (radioButton2 == sender as RadioButton || radioButton2.Checked != true) {
                radioButton2.Checked = !radioButton1.Checked;
                radioButton1.Checked = !radioButton2.Checked;
                toolStripMenuItem3.Checked = radioButton2.Checked;
                toolStripMenuItem2.Checked = !toolStripMenuItem3.Checked;
            }
        }
        #endregion toolStrip
    }

}
