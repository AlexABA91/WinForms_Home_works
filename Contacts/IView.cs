using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts {
    internal interface IView {
        event EventHandler<EventArgs> secondDialogCloseEvent;
        event EventHandler<EventArgs> MainFormClosing;
        event EventHandler<EventArgs> TransferFromFormToContacts;
        List<string>? ShowInListBox { get; set; }
        List<string> dialogInfo { get; set; }
        string? CurrentItem { get; set; }
        int ControlValue { get; set; }

        void RedrawDialogSecondForm();
        void ContactsOnScreen();
        void ShowInfoDialog();
    }
}
