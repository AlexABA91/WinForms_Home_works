using System.Linq;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace BooksAndAuthor;
partial class Form1 : Form {
    List<AuthorAndBooks> itemsLsit;

    string comboBoxString = "Выберите Автора";
  

    public Form1() {
        InitializeComponent();
        itemsLsit = new List<AuthorAndBooks>();
        DrowInBox();
    }

    private void ClickOptionButton(object sender, EventArgs e) {

        var button = sender as ToolStripMenuItem;

        if (button == toolStripMenuAutorAdd) {
            AuthorAndBooks newAutor;
            var df = new Form2("Введите нового Автора:");
            if (df.ShowDialog() == DialogResult.OK) {
                newAutor = new AuthorAndBooks(df.TextBox);
                itemsLsit.Add(newAutor);
                df.Text = "Новый Автор";
                comboBox1.Items.Add(newAutor.Author);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(newAutor.Author);
                
            }
        }
        else if (button == toolStripMenuEditAutor) {
            try {
                var nameStr = comboBox1.Text;
                var df = new Form2("Редактор Автора:");
                var autor = itemsLsit.Find(x => x.Author == nameStr.ToString());
                if (autor != null) {
                    df.TextBox = autor.Author;
                    if (df.ShowDialog() == DialogResult.OK) {
                        comboBox1.Items.Remove(autor.Author);
                        autor.Author = df.TextBox;
                        comboBox1.Items.Add(autor.Author);
                        comboBox1.SelectedIndex = comboBox1.Items.IndexOf(autor.Author);
                    }
                }
            }
            catch { MessageBox.Show(comboBoxString); }
        }
        else if (button == toolStripMenuAutorDelet) {
            try {
                var nameStr = comboBox1.Text;
                var autor = itemsLsit.Find(x => x.Author == nameStr);
                if (autor != null) {
                    var resolt = MessageBox.Show($"Вы действительно хотите Удалить {autor.Author}",
                        "Удалить?", MessageBoxButtons.OKCancel);
                    if (resolt == DialogResult.OK) {
                        var index = comboBox1.Items.IndexOf(autor.Author);
                        itemsLsit.Remove(autor);
                        comboBox1.Items.Remove(autor.Author);
                        comboBox1.SelectedIndex = --index;
                    }
                }
            }
            catch { MessageBox.Show("Выберите Автора для удаления "); }
        }
        else if (button == toolStripMenuBookAdd) {
            try {
                var nameStr = comboBox1.Text;
                
                var autor = itemsLsit.Find(x => x.Author == nameStr);
                if (autor != null) {
                    var df = new Form2($"Добавить кнугу Для Автора {autor.Author}:");
                    if (df.ShowDialog() == DialogResult.OK) {
                        autor.SetBooksInList(df.TextBox);
                    }
                }
                
            }
            catch { MessageBox.Show(comboBoxString); }
        }
        else if (button == toolStripMenuBookEdit) {
            try {
                var nameStr = listBox1.Text;
                foreach (var item in itemsLsit) {
                    if (item.GetBooksList.Contains(nameStr!)) {
                        var df = new Form2("Редактировать название книги :");
                        df.TextBox = nameStr!;
                        if (df.ShowDialog() == DialogResult.OK) {
                            item.GetBooksList.Remove(nameStr!);
                            item.SetBooksInList(df.TextBox);
                            break;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Выберите Книгу для Редактировния"); }
        }
        else if (button == toolStripMenuBookDelet) {
            try {
                var nameStr = listBox1.Text;
                foreach (var item in itemsLsit) {
                    if (item.GetBooksList.Contains(nameStr!)) {
                        var resolt = MessageBox.Show($"Вы действительно хотите Удалить {nameStr}",
                        "Удалить?", MessageBoxButtons.OKCancel);
                        if (resolt == DialogResult.OK) {
                            item.GetBooksList.Remove(nameStr!);
                            break;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Выберите Книгу для удаления"); }
        }


        checkBox1_CheckedChanged(this, EventArgs.Empty);
    }
    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
        try {
            if (checkBox1.Checked == true) {
                DrowAutorBooks(sender);              
            }
            else {
                comboBox1.Text = comboBoxString;
                DrowInBox(); }
        }
        catch {
            checkBox1.Checked = false;
            MessageBox.Show(comboBoxString); }
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
       
        if (checkBox1.Checked == true) {
            DrowAutorBooks(sender);
        };
    }

    void DrowInBox() {
       
        listBox1.Items.Clear();
        foreach (var autor in itemsLsit) {
            
           
            foreach (var item in autor.GetBooksList) {
                listBox1.Items.Add(item);
                listBox1.Sorted = true;
            }
        }
    }
    void DrowAutorBooks(object sender) {
        var filtrAutor = comboBox1.SelectedItem.ToString();

        var autor = itemsLsit.Find(x => x.Author == filtrAutor);
        if (autor is AuthorAndBooks autorOk) {
            listBox1.Items.Clear();
            foreach (var item in autorOk.GetBooksList) {
                listBox1.Items.Add(item);
            }
        }
    }
    private void toolStripMenuOpenButton_Click(object sender, EventArgs e) {

        try {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                var openPath = openFileDialog1.FileName;
                OpenFile(openPath);
                DrowInBox();
            }
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message, "Worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
       
    }
    void OpenFile(string openPat) {
        using (var st = new FileStream(openPat, FileMode.Open)) {
            var ds = new DataContractJsonSerializer(typeof(List<AuthorAndBooks>));
            itemsLsit =  ds.ReadObject(st) as List < AuthorAndBooks > ?? 
             throw new ArgumentNullException($" {openPat} Файл пуст");
            DrowInBox();
        } 
    
    }
    private void toolStripMenuSeve_Click(object sender, EventArgs e) {
        saveFileDialog1.InitialDirectory = Application.StartupPath;
        if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
           var  SavePath =  openFileDialog1.FileName;
            SaveFile(SavePath);
        }
    }
    void SaveFile(string sevePath) {
        using (var st = new FileStream(sevePath, FileMode.OpenOrCreate)) {
            var sr = new DataContractJsonSerializer(typeof(List<AuthorAndBooks>));
            sr.WriteObject(st, itemsLsit);
        }
    }
    private void toolStripExit_Click(object sender, EventArgs e) {
        Application.Exit();
    }

}


