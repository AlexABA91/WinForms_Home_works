namespace Contacts {
    public partial class DialogForm : Form {
        public string FirstName { get => textBoxFirstName.Text.Trim(); set => textBoxFirstName.Text = value; }
        public string LastName { get => textBoxLastName.Text.Trim(); set => textBoxLastName.Text = value; }
        public string SecondName { get => textBoxSecondName.Text.Trim(); set => textBoxSecondName.Text = value; }
        public string Phone { get => textBoxPhone.Text.Trim(); set => textBoxPhone.Text = value; }
        public string City { get => textBoxCity.Text.Trim(); set => textBoxCity.Text = value; }
        public string Street { get => textBoxStreet.Text.Trim(); set => textBoxStreet.Text = value; }
        public string House { get => textBoxHouse.Text.Trim(); set => textBoxHouse.Text = value; }
        public string Apart { get => textBoxApart.Text.Trim(); set => textBoxApart.Text = value; }

        public DialogForm() {
            InitializeComponent();
        }
        public DialogForm(string firstNam, string lastName, string secondName, string phone, string city, string street, string house, string apart) : this()
            {
            FirstName= firstNam;
            textBoxFirstName.ReadOnly = true;
            LastName = lastName;
            textBoxLastName.ReadOnly = true;
            SecondName = secondName;
            textBoxSecondName.ReadOnly = true;
            Phone = phone;
            textBoxPhone.ReadOnly = true;
            City = city;    
            textBoxCity.ReadOnly = true;
            Street = street;
            textBoxStreet.ReadOnly = true;
            House = house;
            textBoxHouse.ReadOnly = true;
            Apart = apart;
            textBoxApart.ReadOnly = true;
        }
        private void IsSringEmpty(object sender, EventArgs e) {
            okbButton.Enabled = textBoxFirstName.Text.Length > 1 && textBoxPhone.MaskCompleted;
        }

        
    }
}
