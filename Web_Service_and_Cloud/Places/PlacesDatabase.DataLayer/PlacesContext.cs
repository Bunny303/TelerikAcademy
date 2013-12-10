using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PlacesDatabase.Models;

namespace PlacesDatabase.DataLayer
{
    public class PlacesContext: DbContext
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Vote> Votes { get; set; }

        public PlacesContext()
            : base("PlacesDB")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(40);
            base.OnModelCreating(modelBuilder);
        }
    }
}
