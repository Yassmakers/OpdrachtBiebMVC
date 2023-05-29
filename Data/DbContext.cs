using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BiebWebApp.Data
{
    public class BiebWebAppContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
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
            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1,
                        UserName = "John Doe",
                        Name = "John Doe",
                        Email = "johndoe@example.com",
                        Type = UserType.Member,
                        PasswordHash = passwordHasher.HashPassword(null, "P@ssw0rd") // Set the password here
                    },
                    new User
                    {
                        Id = 2,
                        UserName = "Jane Smith",
                        Name = "Jane Smith",
                        Email = "janesmith@example.com",
                        Type = UserType.Administrator,
                        PasswordHash = passwordHasher.HashPassword(null, "P@ssw0rd") // Set the password here
                    }
                );

            modelBuilder.Entity<Loan>()
        .HasOne(l => l.Reservation)
        .WithMany(r => r.Loans)
        .HasForeignKey(l => l.ReservationId)
        .OnDelete(DeleteBehavior.ClientCascade); // Change DeleteBehavior.Restrict to DeleteBehavior.Cascade

            modelBuilder.Entity<Invoice>()
                .Property(i => i.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = UserType.Member.ToString() },
                new IdentityRole<int> { Id = 2, Name = UserType.Administrator.ToString() },
                new IdentityRole<int> { Id = 3, Name = UserType.Librarian.ToString() }
            );

            modelBuilder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityRole<int>>(entity =>
            {
                entity.ToTable("Roles");
            });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    UserId = 1, // Assign an existing user ID
                    ItemId = 1, // Assign an existing item ID
                    ReservationDate = DateTime.Now
                }
            );

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Title = "Book 1", Author = "Author 1", ItemType = ItemType.Book, Year = 2020, Location = "Library" },
                new Item { Id = 2, Title = "Book 2", Author = "Author 2", ItemType = ItemType.Book, Year = 2019, Location = "Library" },
                new Item { Id = 3, Title = "Magazine 1", Author = "Author 3", ItemType = ItemType.Magazine, Year = 2021, Location = "Library" }
            );

            modelBuilder.Entity<User>().ToTable("Users");

            base.OnModelCreating(modelBuilder);
        }
    }
}
