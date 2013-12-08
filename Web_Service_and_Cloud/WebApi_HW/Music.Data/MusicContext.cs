using System;
using System.Data.Entity;
using Music.Models;

namespace Music.Data
{
    public class MusicContext: DbContext
    {
        public MusicContext()
            : base("MusicDB")
        { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
