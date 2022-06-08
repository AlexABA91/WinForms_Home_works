using System.Diagnostics;

namespace My_File_Explorer {
    class ExplorerData : IModel {
        public string? selectDirectory { get; set; }
        public string? RunFile { get; set; }

        public List<Tuple<string, bool>> GetDirectory(bool start) {
            var Directory = new List<Tuple<string, bool>>();
            bool IsEmpty = false;
            if (!start) {
                if (Directory.Count != 0) Directory.Clear();
                var folserDirectory = System.IO.Directory.GetDirectories(selectDirectory);
                if (folserDirectory != null) {
                    for (int i = 0; i < folserDirectory.Length; i++) {
                        try {
                            IsEmpty = false;
                            var folderInFolder = System.IO.Directory.GetDirectories(folserDirectory[i]);
                            if (folderInFolder.Length == 0) IsEmpty = true;
                        }
                        catch { IsEmpty = true; }
                        finally {
                            Directory.Add(Tuple.Create(folserDirectory[i], IsEmpty));
                        }
                    }
                }
            }
            else {
                var startDirectory = System.IO.Directory.GetLogicalDrives();
                for (int i = 0; i < startDirectory.Length; i++) {
                    IsEmpty = false;
                    try {
                        var FolderInDerectory = System.IO.Directory.GetDirectories(startDirectory[i]);
                        if (FolderInDerectory.Length == 0) IsEmpty = true;
                    }
                    catch { IsEmpty = true; }
                    finally {
                        Directory.Add(Tuple.Create(startDirectory[i], IsEmpty));
                    }
                }
            }
            return Directory;
        }

        public List<string> GetFolder() {
            try {
                var Folder = new List<string>();
                
                var FolderInDerectory = System.IO.Directory.GetDirectories(selectDirectory);
                for (int i = 0; i < FolderInDerectory.Length; i++) {

                    Folder.Add(FolderInDerectory[i]);
                }
                return Folder;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public List<string> GetFile() {
            try {
                var file = new List<string>();
                var FileInDerectory = System.IO.Directory.GetFiles(selectDirectory);
                for (int i = 0; i < FileInDerectory.Length; i++) {

                    file.Add(FileInDerectory[i]);
                }
                return file;
            }
            catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }
        }
        public List<string[]> GetFileInfo() {
            var FilesInfo = new List<string[]>();
            var Files = GetFile();

            for (int i = 0; i < Files.Count; i++) {
                var info = new DirectoryInfo(Files[i]);
                DateTime dw = System.IO.Directory.GetLastWriteTime(Files[i]);
                DateTime dc = System.IO.Directory.GetCreationTime(Files[i]);
                var size = new FileInfo(Files[i]).Length;
                string slen = sizeSTring(size);
                string[] infoarr = { info.Name, dw.ToString(), dc.ToString(), slen };

                FilesInfo.Add(infoarr);
            }
            return FilesInfo;
        }
        public List<string[]> GetFolderInfo() {
            var  FolderInfo = new List<string[]>();
            var Folder = GetFolder();

            for (int i = 0; i < Folder.Count; i++) {
                var info = new DirectoryInfo(Folder[i]);
                DateTime dw = System.IO.Directory.GetLastWriteTime(Folder[i]);
                DateTime dc = System.IO.Directory.GetCreationTime(Folder[i]);

                string[] infoarr = { info.Name, dw.ToString(), dc.ToString() };

                FolderInfo.Add(infoarr);
            }
            return FolderInfo;
        }
        string sizeSTring(long size) {
            string sLen = size.ToString();
            if (size >= (1 << 30))
                sLen = string.Format("{0}Gb", size >> 30);
            else
            if (size >= (1 << 20))
                sLen = string.Format("{0}Mb", size >> 20);
            else
            if (size >= (1 << 10))
                sLen = string.Format("{0}Kb", size >> 10);
            else sLen = string.Format("{0} B", size);
            return sLen;
        }
        public void StartFile() {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = RunFile, UseShellExecute = true });
        }

    }
}
