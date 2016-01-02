namespace DropboxExplorer
{
    public class FolderData : IStorageItem
    {
        public FolderData(string name)
        {
            Name = name;
        }

        public StorageItemType StorageItemType => StorageItemType.Directory;
        public ulong Size => 0;

        public string Name { get; }
    }
}