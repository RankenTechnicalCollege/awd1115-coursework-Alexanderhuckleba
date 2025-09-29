using Microsoft.EntityFrameworkCore;
using Project4_1.Models;
using System;

namespace Project4_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friends" },
                new Category { CategoryId = 3, Name = "Work" }
            );

            // Seed a Contact with a fixed date
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Alex",
                    LastName = "Huckleba",
                    Phone = "555-123-4567",
                    Email = "alex@example.com",
                    DateAdded = new DateTime(2025, 9, 22), // FIXED date
                    CategoryId = 1
                }
            );
        }
    }
}
