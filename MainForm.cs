using System;
using System.Linq;
using System.Text;
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
            var path = CalculatePath(treeView_DirectoryTree.SelectedNode);

            var folderSize = await _storageRepository.GetFolderSizeAsync(path, true);

            var folderSizeInMB = folderSize / 1024.0 / 1024.0;

            label_Results.Text = $"Folder size = {folderSizeInMB:F2} MB";
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

        private async void treeView_DirectoryTree_DoubleClick(object sender, EventArgs e)
        {
            var selectedNode = treeView_DirectoryTree.SelectedNode;

            if (selectedNode != null)
            {
                var items = await _storageRepository.GetItemsAsync(CalculatePath(selectedNode), false);

                selectedNode.Nodes.AddRange((from x in items
                                             where x.StorageItemType == StorageItemType.Directory
                                             select new TreeNode(x.Name)).ToArray());

                selectedNode.Expand();
            }
        }

        private string CalculatePath(TreeNode node)
        {
            var sb = new StringBuilder();

            sb.Insert(0, $"/{node.Text}");

            var thisNode = node.Parent;

            while(thisNode != null)
            {
                sb.Insert(0, $"/{thisNode.Text}");

                thisNode = thisNode.Parent;
            }

            return sb.ToString();
        }
    }
}
