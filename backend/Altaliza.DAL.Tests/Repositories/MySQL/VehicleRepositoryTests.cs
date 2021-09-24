using System.Diagnostics;
using System.Linq;
using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;
using Altaliza.DAL.Repositories.MySQL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Altaliza.DAL.Tests.Repositories.MySQL
{
    [TestFixture]
    public class VehicleRepositoryTests
    {
        private MySQLContext context;
        private VehicleRepository repository;

        [SetUp]
        public void Setup()
        {
            string mySqlConnection = "server=localhost;user=root;password=root;database=altaliza;";
            context = new MySQLContext(
                new DbContextOptionsBuilder<MySQLContext>()
                    .UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)
                ).Options
            );

            repository = new VehicleRepository(context);
        }

        [Test]
        public void SelectVehicle()
        {
            int id = 1;

            Vehicle vehicle = repository.GetOne(id);

            Assert.AreEqual(vehicle.Id, id);
            Assert.AreEqual(vehicle.Name, "Terrorbyte");
            Assert.AreEqual(vehicle.CategoryId, 1);
        }

        [Test]
        public void CreateVehicle()
        {
            int id = 31;
            int categoryId = 1;
            string name = "Teste";
            int stock = 10;
            string image = "teste.png";
            decimal price1Day = 1m;
            decimal price7Days = 7m;
            decimal price15Days = 15m;

            repository.Create(new Vehicle
            {
                Id = id,
                CategoryId = categoryId,
                Name = name,
                Stock = stock,
                Image = image,
                Price1Day = price1Day,
                Price7Days = price7Days,
                Price15Days = price15Days
            });

            repository.Commit();

            Vehicle createdVehicle = repository.GetOne(id);

            Assert.AreEqual(createdVehicle.Id, id);
            Assert.AreEqual(createdVehicle.CategoryId, categoryId);
            Assert.AreEqual(createdVehicle.Name, name);
            Assert.AreEqual(createdVehicle.Stock, stock);
            Assert.AreEqual(createdVehicle.Image, image);
            Assert.AreEqual(createdVehicle.Price1Day, price1Day);
            Assert.AreEqual(createdVehicle.Price7Days, price7Days);
            Assert.AreEqual(createdVehicle.Price15Days, price15Days);
        }

        [Test]
        public void UpdateVehicle()
        {
            CreateVehicle();

            int id = 31;
            int categoryId = 1;
            string name = "Teste";
            int stock = 10;
            string image = "teste.png";
            decimal price1Day = 1m;
            decimal price7Days = 7m;
            decimal price15Days = 15m;

            Vehicle vehicle = repository.GetOne(id);

            vehicle.Id = id;
            vehicle.CategoryId = categoryId;
            vehicle.Name = name;
            vehicle.Stock = stock;
            vehicle.Image = image;
            vehicle.Price1Day = price1Day;
            vehicle.Price7Days = price7Days;
            vehicle.Price15Days = price15Days;

            repository.Update(vehicle);

            Vehicle updatedVehicle = repository.GetOne(id);

            Assert.AreEqual(vehicle.Id, id);
            Assert.AreEqual(vehicle.CategoryId, categoryId);
            Assert.AreEqual(vehicle.Name, name);
            Assert.AreEqual(vehicle.Stock, stock);
            Assert.AreEqual(vehicle.Image, image);
            Assert.AreEqual(vehicle.Price1Day, price1Day);
            Assert.AreEqual(vehicle.Price7Days, price7Days);
            Assert.AreEqual(vehicle.Price15Days, price15Days);
        }

        [Test]
        public void SelectAllVehicles()
        {
            CreateVehicle();
            Assert.Greater(repository.GetAll().Count(), 30);
        }

        [Test]
        public void DeleteVehicle()
        {
            CreateVehicle();

            int id = 31;

            repository.Delete(id);

            repository.Commit();

            Vehicle deletedVehicle = repository.GetOne(id);

            Assert.IsNull(deletedVehicle);
        }

        [Test]
        public void Commit()
        {
            int id = 31;
            int categoryId = 1;
            string name = "Teste";
            int stock = 10;
            string image = "teste.png";
            decimal price1Day = 1m;
            decimal price7Days = 7m;
            decimal price15Days = 15m;

            repository.Create(new Vehicle
            {
                Id = id,
                CategoryId = categoryId,
                Name = name,
                Stock = stock,
                Image = image,
                Price1Day = price1Day,
                Price7Days = price7Days,
                Price15Days = price15Days
            });

            Assert.IsNull(repository.GetOne(id));

            repository.Commit();

            Assert.IsNotNull(repository.GetOne(id));
        }

        [TearDown]
        public void TearDown()
        {
            if (repository.GetAll().Count() > 30)
            {
                repository.Delete(31);
                repository.Commit();
            }
        }
    }
}