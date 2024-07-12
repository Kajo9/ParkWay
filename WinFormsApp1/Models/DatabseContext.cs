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
                .HasForeignKey(p => p.FloorId)
                .IsRequired();
        }

    }
}
