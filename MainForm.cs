using System;
using System.Linq;
using System.Windows.Forms;

namespace DropboxExplorer
{
    public partial class MainForm : Form
    {
        readonly IStorageRepository _storageRepository = new DropboxRepository();

        public MainForm()
        {
            InitializeComponent();

            UpdateControlStates(false);
        }

        private async void button_GetFolderSize_Click(object sender, EventArgs e)
        {
            var selectedNodeName = treeView_DirectoryTree.SelectedNode.Text;

            var folderSize = await _storageRepository.GetFolderSizeAsync($"/{selectedNodeName}", true);

            var folderSizeInMB = folderSize / 1024.0 / 1024.0;

            label_Results.Text = $"Folder size = {folderSizeInMB:F2}";
        }

        private void textBox_AuthToken_TextChanged(object sender, EventArgs e)
        {
            var authToken = textBox_AuthToken.Text;

            UpdateControlStates(!string.IsNullOrEmpty(authToken));

            _storageRepository.SetAuthToken(authToken);
        }

        private async void button_ListDirectoryStructure_Click(object sender, EventArgs e)
        {
            var items = await _storageRepository.GetItemsAsync("", false);

            treeView_DirectoryTree.Nodes.Clear();

            treeView_DirectoryTree.Nodes.AddRange((from x in items
                                                   where x.StorageItemType == StorageItemType.Directory
                                                   select new TreeNode(x.Name)).ToArray());
        }

        private void UpdateControlStates(bool enable)
        {
            treeView_DirectoryTree.Enabled = enable;
            button_ListDirectoryStructure.Enabled = enable;
            button_GetFolderSize.Enabled = enable;
        }
    }
}
