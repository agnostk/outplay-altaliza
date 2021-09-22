using System.Collections.Generic;
using Altaliza.Core.Entities;
using Altaliza.DAL.Constraints;
using Microsoft.EntityFrameworkCore;

namespace Altaliza.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CharacterVehicle> CharacterVehicle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>(new CharacterConstraints().Configure);
            modelBuilder.Entity<Vehicle>(new VehicleConstraints().Configure);
            modelBuilder.Entity<Category>(new CategoryConstraints().Configure);
            modelBuilder.Entity<CharacterVehicle>(new CharacterVehicleConstraints().Configure);

            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category {Id = 1, Name = "Commercial", Description = "Comerciais"},
                new Category {Id = 2, Name = "Compact", Description = "Compactos"},
                new Category {Id = 3, Name = "Military", Description = "Militares"},
                new Category {Id = 4, Name = "Motorcycle", Description = "Motos"},
                new Category {Id = 5, Name = "Off-Road", Description = "Off-Roads"},
                new Category {Id = 6, Name = "Sedan", Description = "Sedans"},
                new Category {Id = 7, Name = "Sport", Description = "Esportivos"},
                new Category {Id = 8, Name = "Super", Description = "Superesportivos"},
                new Category {Id = 9, Name = "SUV", Description = "SUVs"},
                new Category {Id = 10, Name = "Van", Description = "Vans"},
            });
        }
    }
}
