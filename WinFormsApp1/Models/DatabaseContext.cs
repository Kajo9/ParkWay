using Microsoft.EntityFrameworkCore;

namespace ParkWay.Models
{
     public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(GetOptions())
        {
                
        }

        private static DbContextOptions GetOptions()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ParkWayContext"].ConnectionString;

            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public  DbSet<Floor> Floors { get; set; }

        public DbSet<ParkingSpot> ParkingSpots { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Reservation> Reservations { get; set; }


        public void RefreshParkingSpotStatus()
        {
            var expiredReservations = Reservations.Where(r => r.To < DateTime.Now).ToList();

            foreach (var reservation in expiredReservations)
            {
                var parkingSpot = ParkingSpots.Find(reservation.ParkingSpotId);
                if (parkingSpot != null)
                {
                    parkingSpot.isAvailable = true;
                    Reservations.Remove(reservation);
                }
            }

            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Floor>()
                .HasMany(f => f.ParkingSpots)
                .WithOne(p => p.Floor)
                .HasForeignKey(p => p.FloorId)
                .IsRequired();

            modelBuilder.Entity<ParkingSpot>()
               .HasOne(p => p.Floor)
               .WithMany(f => f.ParkingSpots)
               .HasForeignKey(p => p.FloorId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.ParkingSpot)
                .WithMany()
                .HasForeignKey(p => p.ParkingSpotId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);
        }
    }
}
