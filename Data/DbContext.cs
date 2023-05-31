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
                        NormalizedUserName = "JOHNDOE@EXAMPLE.COM",
                        NormalizedEmail = "JOHNDOE@EXAMPLE.COM",
                        EmailConfirmed = false,
                        LockoutEnabled = true,
                        SecurityStamp = Guid.NewGuid().ToString("D"),
                        ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                        Type = UserType.Member,
                        PasswordHash = passwordHasher.HashPassword(null, "YourDesiredPasswordHere")
                    },
                    new User
                    {
                        Id = 2,
                        UserName = "Jane Smith",
                        Name = "Jane Smith",
                        Email = "janesmith@example.com",
                        NormalizedUserName = "JANESMITH@EXAMPLE.COM",
                        NormalizedEmail = "JANESMITH@EXAMPLE.COM",
                        EmailConfirmed = false,
                        LockoutEnabled = true,
                        SecurityStamp = Guid.NewGuid().ToString("D"),
                        ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                        Type = UserType.Administrator,
                        PasswordHash = passwordHasher.HashPassword(null, "YourDesiredPasswordHere")
                    }
                );


            modelBuilder.Entity<Item>()
                .Property(i => i.Status)
                .HasConversion<int>();
            modelBuilder.Entity<Loan>().HasData(
                new Loan { Id = 1, UserId = 1, ItemId = 2, ReservationId = 1, LoanDate = DateTime.Now.AddDays(-7), ReturnDate = DateTime.Now.AddDays(14) }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, UserId = 1, ItemId = 2, ReservationDate = DateTime.Now.AddDays(-7) },
                new Reservation { Id = 2, UserId = 2, ItemId = 3, ReservationDate = DateTime.Now.AddDays(-7) }
            );

            modelBuilder.Entity<Item>().HasData(
     new Item { Id = 1, Title = "Book 1", Author = "Author 1", ItemType = ItemType.Book, Year = 2018, Location = "Library" },
     new Item { Id = 2, Title = "Book 2", Author = "Author 2", ItemType = ItemType.Book, Year = 2019, Location = "Library" },
     new Item { Id = 3, Title = "Magazine 1", Author = "Author 3", ItemType = ItemType.Magazine, Year = 2021, Location = "Library" },
     new Item { Id = 4, Title = "Book 3", Author = "Author 4", ItemType = ItemType.Book, Year = 2020, Location = "Library" },
     new Item { Id = 5, Title = "Magazine 2", Author = "Author 5", ItemType = ItemType.Magazine, Year = 2022, Location = "Library" },
     new Item { Id = 6, Title = "Book 4", Author = "Author 6", ItemType = ItemType.Book, Year = 2017, Location = "Library" },
     new Item { Id = 7, Title = "Magazine 3", Author = "Author 7", ItemType = ItemType.Magazine, Year = 2021, Location = "Library" },
     new Item { Id = 8, Title = "Book 5", Author = "Author 8", ItemType = ItemType.Book, Year = 2019, Location = "Library" },
     new Item { Id = 9, Title = "Magazine 4", Author = "Author 9", ItemType = ItemType.Magazine, Year = 2020, Location = "Library" },
     new Item { Id = 10, Title = "Book 6", Author = "Author 10", ItemType = ItemType.Book, Year = 2022, Location = "Library" }
 );


            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Reservation)
                .WithMany(r => r.Loans)
                .HasForeignKey(l => l.ReservationId)
                .OnDelete(DeleteBehavior.NoAction); // Change DeleteBehavior.Restrict to DeleteBehavior.NoAction

            modelBuilder.Entity<User>().ToTable("Users");

            base.OnModelCreating(modelBuilder);
        }
    }
}
