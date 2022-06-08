using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_File_Explorer {
    internal interface IView {
        List<Tuple<string, bool>> Directory { get; set; }
        List<string> Files { get; set; }
         List<string> Folder { get; set; }
        string? selectDirectory { get; set; }

        event EventHandler<EventArgs> ExtendTree;
        event EventHandler<EventArgs>? SelectFolder;
        event EventHandler<EventArgs>? FileRun;
        void ShowDirectoryNode();

        List<string[]> FolderInfo { get; set; }
        List<string[]> FilesInfo { get; set; }
        string? RunFile { get; set; }
    }
}
