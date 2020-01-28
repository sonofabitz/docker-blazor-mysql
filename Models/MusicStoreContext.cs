using MySql.Data.MySqlClient;    
using System;    
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.DataAnnotations;
    
namespace MyBlazorServerTest.Models    
{    
    public class MusicStoreContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseMySQL("server=mysql-netcore;database=MusicStoreDB;user=root;password=password");
        }

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