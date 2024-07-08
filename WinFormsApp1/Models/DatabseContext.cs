using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
     public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=ASUS_09\SQLEXPRESS;Initial Catalog=ParkWayDB;User ID=sa;Password=plavi100;")
        {
                
        }

        public  DbSet<Base> Bases { get; set; }

        public  DbSet<Floor> Floors { get; set; }

        public  DbSet<Invoice> Invoices { get; set; }

        public DbSet<ParkingOverview> ParkingOverviews { get; set; }

        public DbSet<ParkingSpot> ParkingSpots { get; set; }

        public DbSet<Purchases> Purchases { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

    }
}
