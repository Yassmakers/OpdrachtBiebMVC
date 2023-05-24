using Microsoft.EntityFrameworkCore;
using BiebWebApp.Models;


namespace BiebWebApp.Data
{
    public class BiebWebAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public BiebWebAppContext(DbContextOptions<BiebWebAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John Doe", Type = UserType.Member },
                new User { Id = 2, Name = "Jane Smith", Type = UserType.Administrator }
            // Add more user instances if needed latere hier
            );

            // Seed data for other entities later imma use things like (e.g., Item, Reservation, Invoice) in a similar manner

            base.OnModelCreating(modelBuilder);
        }
    }
}
