using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dropbox.Api;
using System.Linq;
using Dropbox.Api.Files;

namespace DropboxExplorer
{
    public class DropboxRepository : IStorageRepository
    {
        private string _authToken;

        public void SetAuthToken(string authToken)
        {
            _authToken = authToken;
        }

        public async Task<IEnumerable<IStorageItem>> GetItemsAsync(string rootPath, bool recursive)
        {
            using(var client = CreateClient())
            {
                var results = new List<IStorageItem>();

                var response = await client.Files.ListFolderAsync(rootPath, recursive, true);

                results.AddRange(response.Entries.Select(ResultSelectorCallback));

                while(response.HasMore)
                {
                    response = await client.Files.ListFolderContinueAsync(response.Cursor);

                    results.AddRange(response.Entries.Select(ResultSelectorCallback));
                }

                return results;
            }
        }

        private IStorageItem ResultSelectorCallback(Metadata metadata)
        {
            if (metadata.IsFile)
            {
                return new FileData(metadata.Name, metadata.AsFile.Size);
            }

            if (metadata.IsFolder)
            {
                return new FolderData(metadata.Name);
            }

            throw new Exception("Unhandled file type");
        }

        public async Task<ulong> GetFolderSizeAsync(string rootPath, bool recursive)
        {
            var items = await GetItemsAsync(rootPath, recursive);

            return (ulong)items.Sum(x => (long)x.Size); //(todo) Casting like this can cause loss of data - change this
        }

        private DropboxClient CreateClient()
        {
            return new DropboxClient(_authToken);
        }
    }
}
