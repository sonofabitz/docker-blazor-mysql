using MySql.Data.MySqlClient;    
using System;    
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
    
namespace MyBlazorServerTest.Models    
{    
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }

		public IConfiguration Configuration { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
} 