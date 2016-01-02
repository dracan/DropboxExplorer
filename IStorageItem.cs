namespace DropboxExplorer
{
    public interface IStorageItem
    {
        string Name { get; }

        StorageItemType StorageItemType { get; }

        ulong Size { get; }
    }
}