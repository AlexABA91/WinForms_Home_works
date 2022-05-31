using System;
using System.Linq;

namespace Contacts {
    internal class Presenter {
     enum operation{minus =0, redraw, showInfo} 
        private readonly IModel model;
        private readonly IView mainForm;

        public Presenter(IModel _model, IView _mainForm) {
            
            mainForm = _mainForm;
            mainForm.secondDialogCloseEvent += new EventHandler<EventArgs>(FromFormToModel!);
            mainForm.MainFormClosing += new EventHandler<EventArgs>(FormClose!);
            mainForm.TransferFromFormToContacts += new EventHandler<EventArgs>(OperationChecker!);

            model = _model;
            FromModelToMainForm();
        }

        public void FromFormToModel(object sender, EventArgs e) {
            Contact contact = new Contact(mainForm.dialogInfo[0], mainForm.dialogInfo[1],mainForm.dialogInfo[2],
                mainForm.dialogInfo[3], mainForm.dialogInfo[4], mainForm.dialogInfo[5], mainForm.dialogInfo[6], mainForm.dialogInfo[7]);
            model.NewContact = contact;
            model.Add();
            FromModelToMainForm();
        }
        public void FromModelToMainForm() {
            List<string> stringList = new List<string>();
            if (mainForm.ControlValue == (int)operation.minus) {
                foreach (var item in model.ContactsList) {
                    stringList.Add(item.ToString());
                }
                mainForm.ShowInListBox = stringList;
                mainForm.ContactsOnScreen();
            }
            else if (mainForm.ControlValue == (int)operation.redraw) {

                mainForm.dialogInfo = model.paramList;
                mainForm.RedrawDialogSecondForm();
            }
            else if (mainForm.ControlValue == (int)operation.showInfo) {

                mainForm.dialogInfo = model.paramList;
                mainForm.ShowInfoDialog();
            }


        }
        public void FormClose(object sender, EventArgs e) {
            model.Save();
        }
        public void OperationChecker(object sender, EventArgs e) {
            if (mainForm.ControlValue == (int)operation.minus) {
                model.CurrentItem = mainForm.CurrentItem;
                model.Remove();
                FromModelToMainForm();
            }
            else if (mainForm.ControlValue == (int)operation.redraw ) {
                model.CurrentItem = mainForm.CurrentItem;
                model.Change();
                FromModelToMainForm();
            } else if (mainForm.ControlValue == (int)operation.showInfo)  {
                model.CurrentItem = mainForm.CurrentItem;
                model.Info();
                FromModelToMainForm();
            }
        }
    }
}
