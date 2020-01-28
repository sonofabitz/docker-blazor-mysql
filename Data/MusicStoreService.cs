using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyBlazorServerTest.Models;

namespace MyBlazorServerTest.Data
{
    public class MusicStoreService
    {
        public async Task<Album[]> GetAlbumsAsync()
        {
            return await Task.Run(() =>
            {
                using (var context = new MusicStoreContext())
                {
                    return context.Albums.ToArray();
                }
            });
        }

        // public IAsyncEnumerable<Album> GetAllAlbums()
        // {
        //     using (var context = new MusicStoreContext())
        //     {
        //         return context.Albums.ToAsyncEnumerable();
        //     }
        // }
    }
}