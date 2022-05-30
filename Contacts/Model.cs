using System;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace Contacts {
    class Model : IModel {

        public List<Contact> ContactsList { get; set; }
        public List<string> paramList { get; set; }
        public Contact? NewContact { get; set; }
        public string? CurrentItem { get; set; }

        public event EventHandler<EventArgs>? ModelChange;
        public Model() {
            ContactsList = new List<Contact>();
            paramList = new List<string>();  
            Load(); 
        }

        public void Add() {
            if (NewContact != null)
                ContactsList.Add(NewContact);
                ObserverContacts();
        }

        public void Change() {
            if (CurrentItem != null && ContactsList != null) {
                var item = ContactsList.Find(x => x.ToString() == CurrentItem);
                if (item != null) {
                    paramList.Clear();
                    paramList.Add(item.FirstName);
                    paramList.Add(item.LastName);
                    paramList.Add(item.SecondName);
                    paramList.Add(item.Phone);
                    paramList.Add(item.City);
                    paramList.Add(item.Street);
                    paramList.Add(item.HouseNum);
                    paramList.Add(item.Apartment);
                    ContactsList.Remove(item);
                    ObserverContacts();
                }
            }
        }
        public void Info() {
            if (CurrentItem != null && ContactsList != null) {
                var item = ContactsList.Find(x => x.ToString() == CurrentItem);
                if (item != null) {
                    paramList.Clear();
                    paramList.Add(item.FirstName);
                    paramList.Add(item.LastName);
                    paramList.Add(item.SecondName);
                    paramList.Add(item.Phone);
                    paramList.Add(item.City);
                    paramList.Add(item.Street);
                    paramList.Add(item.HouseNum);
                    paramList.Add(item.Apartment);
                    ObserverContacts();
                }
            }
        }
     

        public void Remove() {
            if (CurrentItem != null && ContactsList != null) {
                var item = ContactsList.Find(x => x.ToString() == CurrentItem);
                if(item != null)
                ContactsList.Remove(item);
                ObserverContacts();
            }
        }

        public void ObserverContacts() {
            ModelChange?.Invoke(this, EventArgs.Empty);
        }
        public void Save() {
            try {
                using (var fa = new FileStream(Path.Combine(Application.StartupPath + "File.json")
                    , FileMode.Create)) {
                    var jd = new DataContractJsonSerializer(typeof(List<Contact>));
                    jd.WriteObject(fa, ContactsList);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void Load() {
            try {
                using (var fa = new FileStream(Path.Combine(Application.StartupPath + "File.json"), FileMode.Open)) {
                    var jd = new DataContractJsonSerializer(typeof(List<Contact>));
                    ContactsList = jd.ReadObject(fa) as List<Contact> ?? throw
                    new ArgumentNullException("Беда с загрузкой Файла");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}