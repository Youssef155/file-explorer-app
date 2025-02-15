using System.IO;

namespace FileExplorerApp
{
    public partial class Form1 : Form
    {
        private string currentPathLeft = string.Empty;
        private string currentPathRight = string.Empty;

        private string lastAccessedPath = string.Empty;
        private ListView lastAccessedListView = null;
        private TextBox lastAccessedTextBox = null;

        private string theOtherPath = string.Empty;
        private ListView theOtherListView = null;
        private TextBox theOtherTextBox = null;

        public Form1()
        {
            InitializeComponent();

            LeftListView.ItemActivate += listView_ItemActivate;
            RightListView.ItemActivate += listView_ItemActivate;

        }

        // Configure the ListView
        private void SetupListView(ListView listView)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("Name", 300);
            listView.Columns.Add("Type", 100);
            listView.Columns.Add("Size", 100);
        }

        private void PopulateDrives(ListView listView)
        {
            listView.Items.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                ListViewItem item = new ListViewItem(drive.Name);
                item.SubItems.Add("Drive");
                item.SubItems.Add((drive.TotalSize / (1024 * 1024 * 1024)).ToString());
                item.Tag = drive.Name;
                listView.Items.Add(item);
            }
        }

        public void PopulateFolderContents(ListView listView, string path)
        {
            listView.Items.Clear();

            // Add "." and ".." for navigation
            listView.Items.Add(new ListViewItem(".") { SubItems = { "", "" }, Tag = path });
            listView.Items.Add(new ListViewItem("..") { SubItems = { "", "" }, Tag = Directory.GetParent(path)?.FullName ?? "" });

            // Add directories
            foreach (string dir in Directory.GetDirectories(path))
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(dir));
                item.SubItems.Add("Folder");
                item.SubItems.Add("");
                item.Tag = dir;
                listView.Items.Add(item);
            }

            // Add files
            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(file);
                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                item.SubItems.Add("File");
                item.SubItems.Add((fileInfo.Length / (1024 * 1024)).ToString() + " MB");
                item.Tag = file;
                listView.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupListView(LeftListView);
            SetupListView(RightListView);

            PopulateDrives(LeftListView);
            PopulateDrives(RightListView);
        }

        private void RightListView_ItemActivate(object sender, EventArgs e)
        {
            if (LeftListView.SelectedItems[0].Text == ".")
            {
                PopulateDrives(LeftListView);
            }

            if (RightListView.SelectedItems.Count > 0)
            {
                string selectedPath = Path.Combine(currentPathRight, RightListView.SelectedItems[0].Text);

                if (Directory.Exists(selectedPath))
                {
                    PopulateFolderContents(RightListView, selectedPath);
                    currentPathRight = selectedPath;
                    rightTextBox.Text = currentPathRight;
                }
                else if (File.Exists(selectedPath))
                {
                    MessageBox.Show("This is a file and cannot be opened.");
                }
            }
        }

        private void LeftListView_ItemActivate_1(object sender, EventArgs e)
        {
            if (LeftListView.SelectedItems[0].Text == ".")
            {
                PopulateDrives(LeftListView);
            }

            if (LeftListView.SelectedItems.Count > 0)
            {
                string selectedPath = Path.Combine(currentPathLeft, LeftListView.SelectedItems[0].Text);

                if (Directory.Exists(selectedPath))
                {
                    // Open the folder
                    PopulateFolderContents(LeftListView, selectedPath);
                    currentPathLeft = selectedPath; // Update the current path for the left pane
                    leftTextBox.Text = currentPathLeft; // Update textbox
                }
                else if (File.Exists(selectedPath))
                {
                    MessageBox.Show("This is a file and cannot be opened.");
                }
            }
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView == LeftListView)
            {
                lastAccessedPath = currentPathLeft;
                lastAccessedListView = LeftListView;
                lastAccessedTextBox = leftTextBox;
            }
            else if (listView == RightListView)
            {
                lastAccessedPath = currentPathRight;
                lastAccessedListView = RightListView;
                lastAccessedTextBox = rightTextBox;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentPathLeft) && Directory.GetParent(currentPathLeft) != null)
            {
                if (!string.IsNullOrEmpty(lastAccessedPath) && Directory.GetParent(lastAccessedPath) != null)
                {
                    lastAccessedPath = Directory.GetParent(lastAccessedPath).FullName;

                    PopulateFolderContents(lastAccessedListView, lastAccessedPath);

                    lastAccessedTextBox.Text = lastAccessedPath;
                }
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if(lastAccessedListView == LeftListView)
            {
                theOtherListView = RightListView;
                theOtherPath = currentPathRight;
                theOtherTextBox = rightTextBox;
            }
            else
            {
                theOtherListView = LeftListView;
                theOtherPath = currentPathLeft;
                theOtherTextBox = leftTextBox;
            }

            if (lastAccessedListView.SelectedItems.Count > 0)
            {
                string sourcePath = lastAccessedListView.SelectedItems[0].Tag.ToString();
                string destinationPath = Path.Combine(theOtherPath, Path.GetFileName(sourcePath));

                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destinationPath);
                }
                else if (Directory.Exists(sourcePath))
                {
                    DirectoryCopy(sourcePath, destinationPath);
                }

                PopulateFolderContents(theOtherListView, theOtherPath);
            }
        }

        private void DirectoryCopy(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                File.Copy(file, Path.Combine(destDir, Path.GetFileName(file)));
            }
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                DirectoryCopy(subDir, Path.Combine(destDir, Path.GetFileName(subDir)));
            }
        }
    }
}
