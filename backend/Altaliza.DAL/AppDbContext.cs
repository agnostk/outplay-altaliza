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
                new Category { Id = 1, Name = "Commercial", Description = "Comerciais" },
                new Category { Id = 2, Name = "Compact", Description = "Compactos" },
                new Category { Id = 3, Name = "Military", Description = "Militares" },
                new Category { Id = 4, Name = "Motorcycle", Description = "Motos" },
                new Category { Id = 5, Name = "Off-Road", Description = "Off-Roads" },
                new Category { Id = 6, Name = "Sedan", Description = "Sedans" },
                new Category { Id = 7, Name = "Sport", Description = "Esportivos" },
                new Category { Id = 8, Name = "Super", Description = "Superesportivos" },
                new Category { Id = 9, Name = "SUV", Description = "SUVs" },
                new Category { Id = 10, Name = "Van", Description = "Vans" },
            });

            modelBuilder.Entity<Vehicle>().HasData(new List<Vehicle> {
                new Vehicle { Id = 1, CategoryId = 1, Name = "Terrorbyte", Stock = 3, Image = "/vehicles/commercial/terrorbyte.png", Price1Day = 6880m, Price7Days = 41250m, Price15Days = 76320m },
                new Vehicle { Id = 2, CategoryId = 1, Name = "Pounder Custom", Stock = 2, Image = "/vehicles/commercial/pounder-custom.png", Price1Day = 1610m, Price7Days = 9620m, Price15Days = 17790m },
                new Vehicle { Id = 3, CategoryId = 1, Name = "Phantom Custom", Stock = 1, Image = "/vehicles/commercial/phantom-custom.png", Price1Day = 6130m, Price7Days = 36750m, Price15Days = 68000m },
                new Vehicle { Id = 4, CategoryId = 2, Name = "Club", Stock = 5, Image = "/vehicles/compact/club.png", Price1Day = 3840m, Price7Days = 23040m, Price15Days = 42630m },
                new Vehicle { Id = 5, CategoryId = 2, Name = "Weevil", Stock = 2, Image = "/vehicles/compact/weevil.png", Price1Day = 2610m, Price7Days = 15660m, Price15Days = 28980m },
                new Vehicle { Id = 6, CategoryId = 2, Name = "Asbo", Stock = 3, Image = "/vehicles/compact/asbo.png", Price1Day = 1230m, Price7Days = 7350m, Price15Days = 13590m },
                new Vehicle { Id = 7, CategoryId = 3, Name = "Half-track", Stock = 5, Image = "/vehicles/military/half-track.png", Price1Day = 6770m, Price7Days = 40580m, Price15Days = 75070m },
                new Vehicle { Id = 8, CategoryId = 3, Name = "Barrage", Stock = 2, Image = "/vehicles/military/barrage.png", Price1Day = 6370m, Price7Days = 38190m, Price15Days = 70640m },
                new Vehicle { Id = 9, CategoryId = 3, Name = "Vetir", Stock = 3, Image = "/vehicles/military/vetir.png", Price1Day = 3750m, Price7Days = 22500m, Price15Days = 41620m },
                new Vehicle { Id = 10, CategoryId = 4, Name = "Shotaro", Stock = 5, Image = "/vehicles/motorcycle/shotaro.png", Price1Day = 6680m, Price7Days = 40060m, Price15Days = 74100m },
                new Vehicle { Id = 11, CategoryId = 4, Name = "Vindicator", Stock = 2, Image = "/vehicles/motorcycle/vindicator.png", Price1Day = 1890m, Price7Days = 11340m, Price15Days = 20980m },
                new Vehicle { Id = 12, CategoryId = 4, Name = "Cliffhanger", Stock = 3, Image = "/vehicles/motorcycle/cliffhanger.png", Price1Day = 680m, Price7Days = 4050m, Price15Days = 7500m },
                new Vehicle { Id = 13, CategoryId = 5, Name = "Brutus", Stock = 5, Image = "/vehicles/off-road/brutus.png", Price1Day = 8000m, Price7Days = 48000m, Price15Days = 88800m },
                new Vehicle { Id = 14, CategoryId = 5, Name = "Insurgent", Stock = 2, Image = "/vehicles/off-road/insurgent.png", Price1Day = 2700m, Price7Days = 16160m, Price15Days = 29900m },
                new Vehicle { Id = 15, CategoryId = 5, Name = "Verus", Stock = 3, Image = "/vehicles/off-road/verus.png", Price1Day = 576m, Price7Days = 3460m, Price15Days = 6400m },
                new Vehicle { Id = 16, CategoryId = 6, Name = "Taligater S", Stock = 5, Image = "/vehicles/sedans/taligater-s.png", Price1Day = 4490m, Price7Days = 26910m, Price15Days = 49790m },
                new Vehicle { Id = 17, CategoryId = 6, Name = "Warrener", Stock = 2, Image = "/vehicles/sedans/warrener.png", Price1Day = 360m, Price7Days = 2160m, Price15Days = 4000m },
                new Vehicle { Id = 18, CategoryId = 6, Name = "Asterope", Stock = 3, Image = "/vehicles/sedans/asterope.png", Price1Day = 78m, Price7Days = 468m, Price15Days = 870m },
                new Vehicle { Id = 19, CategoryId = 7, Name = "Itali RSX", Stock = 5, Image = "/vehicles/sport/itali-rsx.png", Price1Day = 10400m, Price7Days = 62370m, Price15Days = 115390m },
                new Vehicle { Id = 20, CategoryId = 7, Name = "Neo", Stock = 2, Image = "/vehicles/sport/neo.png", Price1Day = 5630m, Price7Days = 33750m, Price15Days = 62440m },
                new Vehicle { Id = 21, CategoryId = 7, Name = "Rapid GT", Stock = 3, Image = "/vehicles/sport/rapid-gt.png", Price1Day = 400m, Price7Days = 2380m, Price15Days = 4400m },
                new Vehicle { Id = 22, CategoryId = 8, Name = "Krieger", Stock = 5, Image = "/vehicles/super/krieger.png", Price1Day = 8630m, Price7Days = 51750m, Price15Days = 95740m },
                new Vehicle { Id = 23, CategoryId = 8, Name = "Osiris", Stock = 2, Image = "/vehicles/super/osiris.png", Price1Day = 5850m, Price7Days = 35100m, Price15Days = 65000m },
                new Vehicle { Id = 24, CategoryId = 8, Name = "Infernus", Stock = 3, Image = "/vehicles/super/infernus.png", Price1Day = 1320m, Price7Days = 7920m, Price15Days = 14660m },
                new Vehicle { Id = 25, CategoryId = 9, Name = "Landstalker XL", Stock = 5, Image = "/vehicles/suv/landstalker-xl.png", Price1Day = 3660m, Price7Days = 21960m, Price15Days = 40630m },
                new Vehicle { Id = 26, CategoryId = 9, Name = "Contender", Stock = 2, Image = "/vehicles/suv/contender.png", Price1Day = 750m, Price7Days = 4500m, Price15Days = 8330m },
                new Vehicle { Id = 27, CategoryId = 9, Name = "Gresley", Stock = 3, Image = "/vehicles/suv/gresley.png", Price1Day = 90m, Price7Days = 530m, Price15Days = 960m },
                new Vehicle { Id = 28, CategoryId = 10, Name = "Youga Classic 4x4", Stock = 5, Image = "/vehicles/van/youga-classic-4x4.png", Price1Day = 3870m, Price7Days = 23190m, Price15Days = 42890m },
                new Vehicle { Id = 29, CategoryId = 10, Name = "Bison", Stock = 2, Image = "/vehicles/van/bison.png", Price1Day = 90m, Price7Days = 540m, Price15Days = 1000m },
                new Vehicle { Id = 30, CategoryId = 10, Name = "Surfer", Stock = 3, Image = "/vehicles/van/surfer.png", Price1Day = 40m, Price7Days = 200m, Price15Days = 370m },
            });

            modelBuilder.Entity<Character>().HasData(new List<Character> {
                new Character { Id = 1, Name = "Fulano de Tal", Wallet = 250000 }
            });
        }
    }
}
