namespace DropboxExplorer
{
    public class FileData : IStorageItem
    {
        public FileData(string name, ulong sizeInBytes)
        {
            Name = name;
            SizeInBytes = sizeInBytes;
        }

        public StorageItemType StorageItemType => StorageItemType.File;
        public ulong Size => SizeInBytes;

        public string Name { get; }
        public ulong SizeInBytes { get; }
    }
}