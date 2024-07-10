using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ParkWay.Models
{
     public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=ASUS09_K\SQLEXPRESS;Initial Catalog=ParkWayDB;User ID=sa;Password=plavi100;")
        {
                
        }

        public  DbSet<Floor> Floors { get; set; }

        public  DbSet<Invoice> Invoices { get; set; }

        public DbSet<ParkingOverview> ParkingOverviews { get; set; }

        public DbSet<ParkingSpot> ParkingSpots { get; set; }

        public DbSet<Purchases> Purchases { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Floor>()
                .HasMany(f => f.ParkingSpots)
                .WithOne(p => p.Floor)
                .HasForeignKey(p => p.FloorID)
                .IsRequired();
        }

    }
}
