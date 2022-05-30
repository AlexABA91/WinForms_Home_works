using System.Windows.Forms;

namespace Contacts {
    public partial class MainForm : Form, IView {
        DialogForm? secondDialog;
        public List<string>? ShowInListBox { get; set; }
        public List<string> dialogInfo { get; set; }
        public string? CurrentItem { get; set; }
        public int ControlValue { get; set; }

        public event EventHandler<EventArgs>? secondDialogCloseEvent;
        public event EventHandler<EventArgs>? MainFormClosing;
        public event EventHandler<EventArgs>? TransferFromFormToContacts;

        public MainForm() {
            InitializeComponent();
            dialogInfo = new List<string>();
            ControlValue = 0;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs? e) {
            MainFormClosing?.Invoke(this, EventArgs.Empty);
        }
        private void plus_Click(object sender, EventArgs e) {
            if(sender as string != "fromRedraw")
            secondDialog = new DialogForm();
            
            ControlValue = 0; //Сброc, на добавление//
            var resolt = secondDialog?.ShowDialog();

            if (resolt == DialogResult.OK) {
                if (dialogInfo.Count != 0)
                    dialogInfo.Clear();
                dialogInfo.Add(secondDialog!.FirstName);
                dialogInfo.Add(secondDialog.LastName);
                dialogInfo.Add(secondDialog.SecondName);
                dialogInfo.Add(secondDialog.Phone);
                dialogInfo.Add(secondDialog.City);
                dialogInfo.Add(secondDialog.Street);
                dialogInfo.Add(secondDialog.House);
                dialogInfo.Add(secondDialog.Apart);
                secondDialogCloseEvent?.Invoke(this, EventArgs.Empty);
            }
            else if (resolt == DialogResult.Cancel && sender as string == "fromRedraw") {
                secondDialogCloseEvent?.Invoke(this, EventArgs.Empty);
            } ;
        }
        private void minus_Click(object sender, EventArgs e) {
            
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Выберите Контакт");
            }
            else {
               var resolt = MessageBox.Show("Вы действительно хотите Удалить контакт?", "Удаление",MessageBoxButtons.YesNo);
                if (resolt == DialogResult.Yes) {
                    ControlValue = 0;
                    CurrentItem = listBox1.GetItemText(listBox1.SelectedItem);
                    TransferFromFormToContacts?.Invoke(this, EventArgs.Empty);
                }
            }

        }
        private void rewrite_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Выберите Контакт");
            }
            else {
                ControlValue = 1;
                CurrentItem = listBox1.GetItemText(listBox1.SelectedItem);
                TransferFromFormToContacts?.Invoke(this, EventArgs.Empty);
            }
        }
        private void Info_Click(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Выберите Контакт");
            }
            else {
                ControlValue = 2;
                CurrentItem = listBox1.GetItemText(listBox1.SelectedItem);
                TransferFromFormToContacts?.Invoke(this, EventArgs.Empty);
            }
        }
     
        public void ContactsOnScreen() {
            listBox1.Items.Clear();
            if(ShowInListBox != null)
            foreach (var item in ShowInListBox )
                listBox1.Items.Add(item.ToString());
        }
        public void RedrawDialogSecondForm() {
            secondDialog = new DialogForm();
            secondDialog.FirstName = dialogInfo[0];
            secondDialog.LastName = dialogInfo[1];
            secondDialog.SecondName = dialogInfo[2];
            secondDialog.Phone = dialogInfo[3];
            secondDialog.City = dialogInfo[4];
            secondDialog.Street = dialogInfo[5];
            secondDialog.House = dialogInfo[6];
            secondDialog.Apart = dialogInfo[7];
            
            string st = "fromRedraw";
            plus_Click(st, EventArgs.Empty);
            }
        public void ShowInfoDialog() {

            secondDialog = new DialogForm(dialogInfo[0], dialogInfo[1], dialogInfo[2], dialogInfo[3], dialogInfo[4],
                dialogInfo[5], dialogInfo[6], dialogInfo[7]);
            if (secondDialog.ShowDialog() == DialogResult.OK) { };
        }

        private void toolStripExit_Click(object sender, EventArgs e) {
            MainForm_FormClosing(this,null);
            Application.Exit();
        }
    }
}

