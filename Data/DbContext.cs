﻿using Microsoft.EntityFrameworkCore;
using BiebWebApp.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "John Doe", Name = "John Doe", Email = "johndoe@example.com", Type = UserType.Member },
                new User { Id = 2, UserName = "Jane Smith", Name = "Jane Smith", Email = "janesmith@example.com", Type = UserType.Administrator }
            );

            modelBuilder.Entity<Invoice>()
            .Property(i => i.Amount)
            .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = "Member" },
                new IdentityRole<int> { Id = 2, Name = "Administrator" },
                new IdentityRole<int> { Id = 3, Name = "Librarian" }
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

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
        }




    }
}