using Meseum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meseum.DAL
{
    public class MeseumContext: DbContext
    {
        public MeseumContext(DbContextOptions<MeseumContext> options)
        : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Posture> Postures { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<NewsEvent> NewsEvents { get; set; }
       
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<Inventory>()
        //.HasKey(bc => new { bc.CategoryId, bc.LocationId });
        //    modelBuilder.Entity<Inventory>()
        //        .HasOne(bc => bc.Location)
        //        .WithMany(b => b.CategoryLocations)
        //        .HasForeignKey(bc => bc.LocationId);
        //    modelBuilder.Entity<Inventory>()
        //        .HasOne(bc => bc.Category)
        //        .WithMany(c => c.CategoryLocations)
        //        .HasForeignKey(bc => bc.CategoryId);

        }



    }
}
