using System.Collections.Generic;
using System.Threading.Tasks;

namespace DropboxExplorer
{
    public interface IStorageRepository
    {
        void SetAuthToken(string authToken);

        Task<IEnumerable<IStorageItem>> GetItemsAsync(string rootPath, bool recursive);

        Task<ulong> GetFolderSizeAsync(string rootPath, bool recursive);
    }
}