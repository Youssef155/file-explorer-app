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

        // Example for ListView
        public void PopulateDrives(ListView listView)
        {
            listView.Items.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                listView.Items.Add(new ListViewItem(drive.Name));
            }
        }

        public void PopulateFolderContents(ListView listView, string path)
        {
            listView.Items.Clear();

            // Add "." and ".." for navigation
            listView.Items.Add(new ListViewItem("."));
            listView.Items.Add(new ListViewItem(".."));

            // Add directories
            foreach (string dir in Directory.GetDirectories(path))
            {
                listView.Items.Add(new ListViewItem(Path.GetFileName(dir)));
            }

            // Add files
            foreach (string file in Directory.GetFiles(path))
            {
                listView.Items.Add(new ListViewItem(Path.GetFileName(file)));
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
