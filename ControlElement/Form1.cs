using System.Diagnostics;
namespace ControlElement;

public partial class Form1 : Form {
    List<Button> buttonList;
    List<int> arrSort;
    Stopwatch s;
    
    int index;
    int misCaunt;
    int timeSec;
    bool bloc = true;

    public Form1() {
        InitializeComponent();
        #region ListADD
        buttonList = new List<Button>();
        buttonList.Add(button1);
        buttonList.Add(button2);
        buttonList.Add(button3);
        buttonList.Add(button4);
        buttonList.Add(button5);
        buttonList.Add(button6);
        buttonList.Add(button7);
        buttonList.Add(button8);
        buttonList.Add(button9);
        buttonList.Add(button10);
        buttonList.Add(button11);
        buttonList.Add(button12);
        buttonList.Add(button13);
        buttonList.Add(button14);
        buttonList.Add(button15);
        buttonList.Add(button16);
#endregion ListADD
        arrSort = new List<int>();
        
        s = new Stopwatch();
         
    }

    private void NGbutton_Click(object sender, EventArgs e) {
        numericUpDown1.Enabled = false; 
        TimerStop();
        listBox1.Items.Clear();
        timeSec = (int)numericUpDown1.Value;
        progressBar1.Value = 0;
        progressBar1.Minimum = 0;
        progressBar1.Maximum = timeSec;
        progressBar1.Step = 1;
        index = 0;
        bloc = true;
        if (arrSort.Count != 0) 
            arrSort.Clear();
        ButtonTexttInit();
        BlockUblockButton();
        TimerStart();
    }
    private void GameButton_Click(object sender, EventArgs e) {
        var carentButtan = sender as Button;
        if (carentButtan != null) {
           
            var value = Convert.ToInt32(carentButtan!.Text);
            if (arrSort[index] == value) {
                listBox1.Items.Add(value);
                carentButtan!.Enabled = false;
                ++index;
            }
            else ++misCaunt;
        }
        if (index == arrSort.Count) {
            Win();
        }
       
    }
    private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
        timeSec = (int)numericUpDown1.Value;
    }
    private void timer1_Tick(object sender, EventArgs e) {
        --timeSec;
        Text= s.Elapsed.ToString("mm\\:ss");
        progressBar1.PerformStep();
        
        if (timeSec == 0) {
            TimerStop();
            BlockUblockButton();
            Lose();
        }
    }
  
    void ButtonTexttInit() {
        Random r = new Random();
        foreach (var item in buttonList) {
            var value = r.Next(1, 100);
            if (arrSort.Contains(value))
                while (arrSort.Contains(value)) value = r.Next(1, 17);

            item.Text = value.ToString();
            arrSort.Add(value);
        }
        arrSort.Sort();
    }
    void BlockUblockButton() {
        if (bloc) {
            foreach (var item in buttonList) {
                item.Enabled = true;
            }
            bloc = false;
        }
        else {
            foreach (var item in buttonList) {
                item.Enabled = false;
            }
            bloc = true;
        }
    
    }

    void TimerStart() {
        s.Start();
        timer1.Start();
    }
    void TimerStop() {
        s.Reset();
        timer1.Stop();
    }

    private void Win() {
        numericUpDown1.Enabled = true;
        progressBar1.Value = 0;
        if (misCaunt != 0) {
            TimerStop();
            MessageBox.Show("ПОБЕДА!!!! Неправильных выборов: " + misCaunt);
        }
        else {
            TimerStop();
            MessageBox.Show("ПОБЕДА!!!!");
        }
    }
    void Lose() {
        progressBar1.Value = 0;
        numericUpDown1.Enabled = true;
        MessageBox.Show("Время вышло вы проиграли");
    }
}