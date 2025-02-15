using System.IO;

namespace FileExplorerApp
{
    public partial class Form1 : Form
    {
        private string currentPathLeft = string.Empty;
        private string currentPathRight = string.Empty;

        public Form1()
        {
            InitializeComponent();
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
                item.SubItems.Add(fileInfo.Length.ToString() + " bytes");
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
    }
}
