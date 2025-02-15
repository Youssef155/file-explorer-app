using System.Diagnostics;
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
        }


        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupListView(LeftListView);
            SetupListView(RightListView);

            PopulateDrives(LeftListView);
            PopulateDrives(RightListView);
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

            if (listView.SelectedItems.Count > 0)
            {
                if (listView.SelectedItems[0].Text == ".")
                {
                    PopulateDrives(listView);
                    lastAccessedTextBox.Text = "";
                    return;
                }

                string selectedItemPath;

                if (lastAccessedListView.SelectedItems[0].Text == "..")
                    selectedItemPath = Directory.GetParent(lastAccessedPath).FullName;
                else
                    selectedItemPath = listView.SelectedItems[0].Tag.ToString();

                if (Directory.Exists(selectedItemPath))
                {
                    PopulateFolderContents(listView, selectedItemPath);

                    if (listView == LeftListView) currentPathLeft = selectedItemPath;
                    if (listView == RightListView) currentPathRight = selectedItemPath;

                    lastAccessedTextBox.Text = selectedItemPath;
                }
                else if (File.Exists(selectedItemPath))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = selectedItemPath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            if (lastAccessedListView == LeftListView)
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (lastAccessedListView == null || lastAccessedListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            string selectedItemPath = lastAccessedListView.SelectedItems[0].Tag.ToString();

            if (string.IsNullOrEmpty(selectedItemPath))
            {
                MessageBox.Show("Invalid selection. Please try again.");
                return;
            }

            try
            {
                if (File.Exists(selectedItemPath))
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the file: {Path.GetFileName(selectedItemPath)}?",
                                                          "Delete Confirmation",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        File.Delete(selectedItemPath);
                        MessageBox.Show("File deleted successfully.");
                    }
                }
                else if (Directory.Exists(selectedItemPath))
                {
                    // Confirm and delete directory
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the directory: {Path.GetFileName(selectedItemPath)} and all its contents?",
                                                          "Delete Confirmation",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(selectedItemPath, true); // Recursively delete
                        MessageBox.Show("Directory deleted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("The selected item does not exist.");
                }

                // Refresh the last accessed ListView
                PopulateFolderContents(lastAccessedListView, lastAccessedPath);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to delete this item.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while deleting the item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeftArrowBtn_Click(object sender, EventArgs e)
        {
            MoveItem(RightListView, currentPathRight, LeftListView, currentPathLeft);
        }

        private void RightArrowBtn_Click(object sender, EventArgs e)
        {
            MoveItem(LeftListView, currentPathLeft, RightListView, currentPathRight);
        }
        #endregion

        #region Methods
        private void MoveItem(ListView sourceListView, string sourcePath, ListView targetListView, string targetPath)
        {
            if (sourceListView.SelectedItems.Count > 0)
            {
                string selectedItemPath = sourceListView.SelectedItems[0].Tag.ToString();
                string destinationPath = Path.Combine(targetPath, Path.GetFileName(selectedItemPath));

                try
                {
                    if (File.Exists(selectedItemPath))
                    {
                        // Move file
                        File.Move(selectedItemPath, destinationPath);
                    }
                    else if (Directory.Exists(selectedItemPath))
                    {
                        // Move directory
                        Directory.Move(selectedItemPath, destinationPath);
                    }

                    // Refresh both source and target ListViews
                    PopulateFolderContents(sourceListView, sourcePath);
                    PopulateFolderContents(targetListView, targetPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while moving the item: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to move.");
            }
        }
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
                item.SubItems.Add((drive.TotalSize / (1024 * 1024 * 1024)).ToString() + " GB");
                item.Tag = drive.Name;
                listView.Items.Add(item);
            }
        }

        public void PopulateFolderContents(ListView listView, string path)
        {
            listView.Items.Clear();

            // Add "." and ".." for navigation
            listView.Items.Add(new ListViewItem(".") { SubItems = { "", "" } });
            listView.Items.Add(new ListViewItem("..") { SubItems = { "", "" } });

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
        #endregion
    }
}