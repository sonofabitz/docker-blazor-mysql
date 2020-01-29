using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlazorServerTest.Models;
using Microsoft.EntityFrameworkCore;

namespace MyBlazorServerTest.Data
{
    public class MusicStoreService
    {
        private readonly MusicStoreContext _context;

		public MusicStoreService(MusicStoreContext context)
		{
			_context = context;
		}

        public async Task<Album[]> GetAlbumsAsync()
        {
            return await _context.Albums.ToArrayAsync();
        }
    }
}