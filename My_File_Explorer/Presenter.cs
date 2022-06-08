using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_File_Explorer {
    internal class Presenter {
        readonly IView view;
        readonly IModel data;
           
        public Presenter(IModel _data,IView _view) {
            data = _data;
            view = _view;
            StartDirecrory();
            view.ExtendTree +=new EventHandler<EventArgs>( GetDataForTree);
            view.SelectFolder+= new EventHandler<EventArgs>( GetDataForListView); 
            view.FileRun+= new EventHandler<EventArgs>(FileRun); 
        }
        void StartDirecrory() {
            view.Directory = data.GetDirectory(true); ;
            view.ShowDirectoryNode();
        }
        void GetDataForTree(object sender, EventArgs e) {
            try {
                data.selectDirectory = view.selectDirectory;
                view.Directory = data.GetDirectory(false);
                view.Files = data.GetFile();
                view.FilesInfo = data.GetFileInfo();
                view.Folder = data.GetFolder();
                view.FolderInfo = data.GetFolderInfo();
            }
            catch (Exception ex) {

                throw new ArgumentException(ex.Message,nameof(ex));
            }
        }
        void GetDataForListView(object sender, EventArgs e) {
            try {
                data.selectDirectory = view.selectDirectory;
            view.Files = data.GetFile();
            view.FilesInfo = data.GetFileInfo();
            view.Folder = data.GetFolder();
            view.FolderInfo = data.GetFolderInfo();
            }
            catch (Exception ex) {

                throw new ArgumentException(ex.Message, nameof(ex));
            }
        }
        void FileRun(object sender, EventArgs e) {
            data.RunFile = view.RunFile;
            data.StartFile();
        }
    }
}
