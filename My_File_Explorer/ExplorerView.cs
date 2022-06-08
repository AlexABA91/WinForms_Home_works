namespace My_File_Explorer {
    public partial class ExplorerView : Form, IView {
        public List<Tuple<string, bool>> Directory { get; set; }
        public List<string> Files { get; set; }
        public List<string> Folder { get; set; }
        public List<string[]> FolderInfo { get; set; }
        public List<string[]> FilesInfo { get; set; }
        public string? RunFile { get; set; }
        public string selectDirectory { get; set; }

        TreeNode Node;
        ImageList imageList;
        List<TreeNode> NodesList;
        int positionInNodeList = 0;
        bool IsForwardButton;

        public event EventHandler<EventArgs>? ExtendTree;
        public event EventHandler<EventArgs>? SelectFolder;
        public event EventHandler<EventArgs>? FileRun;


        public ExplorerView() {
            InitializeComponent();
            Files = new List<string>();
            Folder = new List<string>();
            FolderInfo = new List<string[]>();
            FilesInfo = new List<string[]>();
            Directory = new List<Tuple<string, bool>>();
            selectDirectory = "";
            Node = new TreeNode();
            imageList = new ImageList();
            NodesList = new List<TreeNode>();
        }
        public void ShowDirectoryNode() {
            imageList.Images.Add(Bitmap.FromFile(@"../../../Resources/folder.ico"));
            imageList.Images.Add(Bitmap.FromFile(@"../../../Resources/a1mu8-xwoih-001.ico"));
            treeView1.ImageList = imageList;

            if (Node.Text != "") {
                TreeNode node, child;
                DelStubFolders();
                for (int i = 0; i < Directory?.Count; i++) {
                    var folder = Directory[i];
                    node = new TreeNode();

                    var nodes = Node.Nodes.Find(folder.Item1, true);

                    if (nodes.Length == 0) {
                        node.Name = folder.Item1;
                        node.Text = folder.Item1.ToString().Replace(selectDirectory, "").Replace("\\", "");
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                        Node.Nodes.Add(node);
                        if (folder.Item2 == false) {
                            child = new TreeNode();
                            child.Name = "empty";
                            node.Nodes.Add(child);
                        }
                    }
                    else {
                        if (folder.Item2 == false) {
                            child = new TreeNode();
                            child.Name = "empty";
                            node = nodes[0];
                            node.Nodes.Add(child);
                        }
                    }
                }
            }
            else {
                TreeNode node, child;
                for (int i = 0; i < Directory?.Count; i++) {
                    var folder = Directory[i];
                    node = new TreeNode();
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    node.Name = folder.Item1;
                    node.Text = folder.Item1.ToString();
                    treeView1.Nodes.Add(node);
                    if (folder.Item2 == false) {
                        child = new TreeNode();
                        child.Name = "empty";
                        node.Nodes.Add(child);
                    }
                }
            }
        }
        void DelStubFolders() {
            TreeNode[] nodes = Node.Nodes.Find("empty", true);
            if (nodes.Length > 0)
                foreach (var node in nodes)
                    treeView1.Nodes.Remove(node);
        }
        void treeView1_AfterExpand(object sender, TreeViewEventArgs e) {
            try {

                Node = e.Node ?? throw new ArgumentNullException("”зел не выбран");
                treeView1.SelectedNode = Node;
                selectDirectory = Node.Name;
                if (!IsForwardButton)
                    NodesListAdd(Node);

                ExtendTree?.Invoke(this, EventArgs.Empty);
                ShowDirectoryNode();
                ShowInListView();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, nameof(ex.Source));
            }
        }
        void ShowInListView() {
            if (positionInNodeList != 0 || IsForwardButton) {
                listView1.Items.Clear();
                var icon = new Icon(@"../../../Resources/folder.ico");
                ImageList image_list1 = new ImageList();
                ImageList image_list2 = new ImageList();

                image_list1.ImageSize = new Size(16, 16);
                image_list2.ImageSize = new Size(32, 32);

                listView1.SmallImageList = image_list1;
                listView1.LargeImageList = image_list2;
                image_list2.ColorDepth = ColorDepth.Depth32Bit;

                image_list1.Images.Add(icon);
                image_list2.Images.Add(icon);

                for (int i = 0; i < Folder.Count; i++) {
                    var info = FolderInfo[i];
                    var item = new ListViewItem(info[0].Replace("\\", ""), 0);
                    for (int j = 1; j < info.Length; j++) {
                        item.SubItems.Add(info[j]);
                    }

                    listView1.Items.Add(item);
                }
                int index = 1;
                for (int i = 0; i < Files.Count; i++) {
                    var info = FilesInfo[i];
                    icon = Icon.ExtractAssociatedIcon(Files[i]);
                    image_list1.Images.Add(icon);
                    image_list2.Images.Add(icon);
                    var item = new ListViewItem(info[0].Replace("\\", ""), index++);
                    for (int j = 1; j < info.Length; j++) {
                        item.SubItems.Add(info[j]);
                    }

                    listView1.Items.Add(item);
                }
            }
            else { listView1.Items.Clear(); }
        }
        void toolStripMenuItem4_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem item) {
                if (item.Tag == "1") listView1.View = View.List;
                else if (item.Tag == "2") listView1.View = View.Details;
                else if (item.Tag == "3") listView1.View = View.Tile;
                else if (item.Tag == "4") listView1.View = View.LargeIcon;
                ShowInListView();
            }
        }
        private void UpdataButton_Click(object sender, EventArgs e) {
            try {
                ExtendTree?.Invoke(this, EventArgs.Empty);
                ShowInListView();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        void NodesListAdd(TreeNode node) {
            if (positionInNodeList < NodesList.Count) {
                NodesList.RemoveRange(NodesList.Count - positionInNodeList, positionInNodeList);
                NodesList.Add(node);
                positionInNodeList = NodesList.Count;
            }
            else {
                NodesList.Add(node);
                positionInNodeList = NodesList.Count;
            }
        }
        void UpButton_Click(object sender, EventArgs e) {
            var node = treeView1.SelectedNode;
            try {
                var chec = node.Parent;
                if (chec != null) {
                    if (positionInNodeList > 0)
                        positionInNodeList--;
                    node.Collapse();
                    treeView1.SelectedNode = node.Parent;
                    selectDirectory = node.Parent.Name;
                    ExtendTree?.Invoke(this, EventArgs.Empty);
                    ShowInListView();
                }
                else {
                    if (positionInNodeList > 0)
                        positionInNodeList--;
                    node.Collapse();
                    treeView1.SelectedNode = null;
                    selectDirectory = null;
                    ShowInListView();
                }
            }
            catch { }
        }
        private void BackButton_Click(object sender, EventArgs e) {
            if (NodesList.Count > 0 && positionInNodeList > 0) {

                TreeNode node;

                if ((positionInNodeList - 1) >= 0)
                    node = NodesList[positionInNodeList - 1];
                else node = NodesList[0];

                if (node.Parent != null)
                    selectDirectory = node.Parent.Name;
                else selectDirectory = node.Name;

                ExtendTree?.Invoke(this, EventArgs.Empty);


                treeView1.SelectedNode = node;
                node.Collapse();
                if (node.Parent != null)
                    treeView1.SelectedNode = node.Parent;
                positionInNodeList--;

                ShowInListView();
            }
        }
        private void ForwardButton_Click(object sender, EventArgs e) {
            if (positionInNodeList <= NodesList.Count) {
                if (positionInNodeList < NodesList.Count) {
                    IsForwardButton = true;
                    treeView1.SelectedNode = NodesList[positionInNodeList];
                    treeView1.SelectedNode.Expand();
                    positionInNodeList++;
                    IsForwardButton = false;
                }
            }
            else positionInNodeList = NodesList.Count;
        }
        private void treeView1_Click(object sender, EventArgs e) {
            try {
                selectDirectory = treeView1.SelectedNode.Name;
                SelectFolder?.Invoke(this, EventArgs.Empty);
                ShowInListView();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e) {
            try {
                var node = treeView1.SelectedNode;
                foreach (TreeNode item in node.Nodes) {
                    item.Collapse();
                }
            }
            catch { };
        }
        private void listView1_DoubleClick(object sender, EventArgs e) {
            var item = listView1.SelectedItems[0];
            if (IsFolder(item)) {
                Node = NodesList[positionInNodeList - 1];
                foreach (TreeNode node in Node.Nodes)
                    if (item.Text == node.Text) {
                        treeView1.SelectedNode = node;
                        node.Expand();
                    }
            }
            else {
                RunFile = Files.Find(x => x.Substring(x.LastIndexOf("\\") + 1) == item.Text);
                FileRun?.Invoke(this, EventArgs.Empty);
            }
        }
        bool IsFolder(ListViewItem item) {
            var f = Folder.Find(x => x.Substring(x.LastIndexOf("\\") + 1) == item.Text);
            return (f == null ? false : true);
        }
    }
}