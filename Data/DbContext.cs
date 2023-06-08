using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bogus;
using System;
using System.Collections.Generic;

namespace BiebWebApp.Data
{
    public class BiebWebAppContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Location> Locations { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public BiebWebAppContext(DbContextOptions<BiebWebAppContext> options)
            : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var faker = new Faker();

            // Generate fake items
            var items = new List<Item>();
            for (int i = 1; i <= 100; i++)
            {
                var item = new Item
                {
                    Id = i,
                    Title = faker.Commerce.ProductName(),
                    Author = faker.Name.FullName(),
                    ItemType = faker.PickRandom<ItemType>(),
                    Year = faker.Random.Int(2000, 2023),
                    Location = faker.Address.City()
                };
                items.Add(item);
            }
            modelBuilder.Entity<Item>().HasData(items);

            // Generate fake users
            var passwordHasher = new PasswordHasher<User>();
            var users = new List<User>
    {
        // Seeded users
        new User
        {
            Id = 1,
            UserName = "admin@example.com",
            Name = "Administrator",
            Email = "admin@example.com",
            NormalizedUserName = "ADMIN@EXAMPLE.COM",
            NormalizedEmail = "ADMIN@EXAMPLE.COM",
            EmailConfirmed = true,
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            Type = UserType.Administrator,
            SubscriptionType = "4", // Set the subscription type as a string for the top subscription
            PasswordHash = passwordHasher.HashPassword(null, "AdminPassword1!"),
            IsBlocked = false // Set the IsBlocked property to false
        },
        new User
        {
            Id = 2,
            UserName = "librarian@example.com",
            Name = "Librarian",
            Email = "librarian@example.com",
            NormalizedUserName = "LIBRARIAN@EXAMPLE.COM",
            NormalizedEmail = "LIBRARIAN@EXAMPLE.COM",
            EmailConfirmed = true,
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            Type = UserType.Librarian,
            SubscriptionType = "3", // Set the subscription type as a string for the basic subscription
            PasswordHash = passwordHasher.HashPassword(null, "LibrarianPassword1!"),
            IsBlocked = false // Set the IsBlocked property to false
        },
        new User
        {
            Id = 3,
            UserName = "member@example.com",
            Name = "Member",
            Email = "member@example.com",
            NormalizedUserName = "MEMBER@EXAMPLE.COM",
            NormalizedEmail = "MEMBER@EXAMPLE.COM",
            EmailConfirmed = true,
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            Type = UserType.Member,
            SubscriptionType = "2", // Set the subscription type as a string for the budget subscription
            PasswordHash = passwordHasher.HashPassword(null, "MemberPassword1!"),
            IsBlocked = false // Set the IsBlocked property to false
        },
        // Dummy users
        new User
        {
            Id = 4,
            UserName = faker.Internet.Email(),
            Name = faker.Name.FullName(),
            Email = faker.Internet.Email(),
            NormalizedUserName = faker.Internet.Email().ToUpper(),
            NormalizedEmail = faker.Internet.Email().ToUpper(),
            EmailConfirmed = true,
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            Type = UserType.Member,
            SubscriptionType = "1", // Set the subscription type as a string for the youth subscription
            PasswordHash = passwordHasher.HashPassword(null, "DummyUser1!"),
            IsBlocked = false // Set the IsBlocked property to false
        },
        new User
        {
            Id = 5,
            UserName = faker.Internet.Email(),
            Name = faker.Name.FullName(),
            Email = faker.Internet.Email(),
            NormalizedUserName = faker.Internet.Email().ToUpper(),
            NormalizedEmail = faker.Internet.Email().ToUpper(),
            EmailConfirmed = true,
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            Type = UserType.Member,
            SubscriptionType = "3", // Set the subscription type as a string for the basic subscription
            PasswordHash = passwordHasher.HashPassword(null, "DummyUser2!"),
            IsBlocked = false // Set the IsBlocked property to false
        },
        new User
        {
            Id = 6,
            UserName = faker.Internet.Email(),
            Name = faker.Name.FullName(),
            Email = faker.Internet.Email(),
            NormalizedUserName = faker.Internet.Email().ToUpper(),
            NormalizedEmail = faker.Internet.Email().ToUpper(),
            EmailConfirmed = true,
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            ConcurrencyStamp = Guid.NewGuid().ToString("D"),
            Type = UserType.Member,
            SubscriptionType = "4", // Set the subscription type as a string for the top subscription
            PasswordHash = passwordHasher.HashPassword(null, "DummyUser3!"),
            IsBlocked = false // Set the IsBlocked property to false
        }
    };
            modelBuilder.Entity<User>().HasData(users);

            // Generate fake reservations
            var reservations = new List<Reservation>();
            for (int i = 1; i <= 5; i++) // Adjust the loop limit as per your desired number of reservations
            {
                var reservation = new Reservation
                {
                    Id = i,
                    UserId = faker.Random.Int(1, 3),
                    ItemId = faker.Random.Int(1, 100),
                    ReservationDate = faker.Date.Past()
                };
                reservations.Add(reservation);
            }
            modelBuilder.Entity<Reservation>().HasData(reservations);

            // Generate fake loans
            var loans = new List<Loan>();
            for (int i = 1; i <= 5; i++) // Adjust the loop limit as per your desired number of loans
            {
                var loan = new Loan
                {
                    Id = i,
                    UserId = faker.Random.Int(1, 3),
                    ItemId = faker.Random.Int(1, 100),
                    ReservationId = faker.Random.Int(1, 5),
                    LoanDate = faker.Date.Past(),
                    ReturnDate = faker.Date.Future()
                };
                loans.Add(loan);
            }
            modelBuilder.Entity<Loan>().HasData(loans);

            // Generate fake locations
            var locations = new List<Location>();
            for (int i = 1; i <= 10; i++)
            {
                var location = new Location
                {
                    Id = i,
                    LocationName = faker.Address.City()
                };
                locations.Add(location);
            }
            modelBuilder.Entity<Location>().HasData(locations);

            // Generate fake invoices
            var invoices = new List<Invoice>();
            for (int i = 1; i <= 50; i++)
            {
                var invoice = new Invoice
                {
                    Id = i,
                    UserId = faker.Random.Int(1, 3),
                    Amount = faker.Finance.Amount(10, 100),
                };
                invoices.Add(invoice);
            }
            modelBuilder.Entity<Invoice>().HasData(invoices);

            // Rest of the code...

            base.OnModelCreating(modelBuilder);
        }

    }
}
