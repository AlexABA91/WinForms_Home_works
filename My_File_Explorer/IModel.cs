using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_File_Explorer {
    internal interface IModel {
        string? selectDirectory { get; set; }
        List<string> GetFolder();
        List<string> GetFile();
        List<string[]> GetFileInfo();
        List<string[]> GetFolderInfo();
       
        List<Tuple<string, bool>> GetDirectory(bool start);
        string? RunFile { get; set; }
        void StartFile();


    }
}
