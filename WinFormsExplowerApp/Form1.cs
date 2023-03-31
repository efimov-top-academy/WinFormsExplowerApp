namespace WinFormsExplowerApp
{
    public partial class Form1 : Form
    {


        string imgPath = @"D:\RPO\folders\";
        string imgExt = ".png";
        string[] imgFileNames = { "docx", "file", "folder", "jpg", "pdf", "png", "txt" };
        public Form1()
        {
            InitializeComponent();
            FillTreeDrives();
        }

        private void btnViewPath_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioView_CheckedChanged(object sender, EventArgs e)
        {
            string text = ((RadioButton)sender).Text;
            switch (text)
            {
                case "View Large Icons": lstViewPath.View = View.LargeIcon; break;
                case "View Small Icons": lstViewPath.View = View.SmallIcon; break;
                case "View Tile": lstViewPath.View = View.Tile; break;
                case "View List": lstViewPath.View = View.List; break;

                default:
                    break;
            }
        }

        void FillTreeDrives()
        {
            try
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    TreeNode nodeDrive = new TreeNode() { Text = drive.Name };
                    FillNode(nodeDrive, drive.Name);
                    treePath.Nodes.Add(nodeDrive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillNode(TreeNode node, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode nodeDir = new TreeNode();
                    nodeDir.Text = dir.Remove(0, dir.LastIndexOf('\\') + 1);
                    node.Nodes.Add(nodeDir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treePath_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length > 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode nodeDir = new(new DirectoryInfo(dirs[i]).Name);
                            FillNode(nodeDir, dirs[i]);
                            e.Node.Nodes.Add(nodeDir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treePath_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstViewPath.Items.Clear();

            string path = e.Node.FullPath;

            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dir.Remove(0, dir.LastIndexOf('\\') + 1);
                item.ImageIndex = 2;
                item.SubItems.Add("dir");
                lstViewPath.Items.Add(item);
            }


            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                //item.ImageIndex = 1;

                string ext = file.Remove(0, file.LastIndexOf('.') + 1);
                switch (ext)
                {
                    case "docx": item.ImageIndex = 0; break;
                    case "jpg": item.ImageIndex = 3; break;
                    case "pdf": item.ImageIndex = 4; break;
                    case "png": item.ImageIndex = 5; break;
                    case "txt": item.ImageIndex = 6; break;
                    default:
                        item.ImageIndex = 1;
                        break;
                }

                item.SubItems.Add(File.GetLastAccessTime(file).ToString());

                lstViewPath.Items.Add(item);
            }
        }
    }
}