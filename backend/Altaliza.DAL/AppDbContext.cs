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
        }
    }
}
