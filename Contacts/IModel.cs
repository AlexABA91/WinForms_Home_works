using System;
using System.Linq;

namespace Contacts {
    internal interface IModel {
        List<string> paramList { get; set; }
        List<Contact> ContactsList { get; set; }
        string? CurrentItem { get; set; }
        Contact? NewContact { get; set; }

        event EventHandler<EventArgs> ModelChange;
        

        void Add();
        void Remove();
        void Change();
        void Save();
        void Load();
        void Info();

        void ObserverContacts();
    }
}