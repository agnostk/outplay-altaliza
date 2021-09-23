using System;
using System.Linq;
using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;
using Altaliza.DAL.Repositories.MySQL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Altaliza.DAL.Tests.Repositories.MySQL
{
    [TestFixture]
    public class CharacterVehicleRepositoryTest
    {
        private MySQLContext context;
        private CharacterVehicleRepository repository;

        [SetUp]
        public void Setup()
        {
            string mySqlConnection = "server=localhost;user=root;password=root;database=altaliza;";
            context = new MySQLContext(
                new DbContextOptionsBuilder<MySQLContext>()
                    .UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)
                ).Options
            );

            repository = new CharacterVehicleRepository(context);
        }

        [Test]
        public void CreateCharacterVehicle()
        {
            int id = 1;
            int characterId = 1;
            int vehicleId = 1;
            DateTimeOffset expirationDate = DateTimeOffset.UtcNow.AddDays(1);

            repository.Create(new CharacterVehicle
            {
                Id = id,
                CharacterId = characterId,
                VehicleId = vehicleId,
                ExpirationDate = expirationDate
            });

            repository.Commit();

            CharacterVehicle createdCharacterVehicle = repository.GetOne(id);

            Assert.AreEqual(createdCharacterVehicle.Id, id);
            Assert.AreEqual(createdCharacterVehicle.CharacterId, characterId);
            Assert.AreEqual(createdCharacterVehicle.VehicleId, vehicleId);
            Assert.AreEqual(createdCharacterVehicle.ExpirationDate, expirationDate);
        }

        [Test]
        public void SelectCharacterVehicle()
        {
            int id = 1;

            CreateCharacterVehicle();

            CharacterVehicle characterVehicle = repository.GetOne(id);

            Assert.AreEqual(characterVehicle.Id, id);
            Assert.Greater(characterVehicle.ExpirationDate, DateTimeOffset.UtcNow);
        }

        [Test]
        public void UpdateCharacterVehicle()
        {
            CreateCharacterVehicle();

            int id = 1;
            int characterId = 1;
            int vehicleId = 3;
            DateTimeOffset expirationDate = DateTimeOffset.UtcNow.AddDays(1);

            CharacterVehicle characterVehicle = repository.GetOne(id);

            characterVehicle.CharacterId = characterId;
            characterVehicle.VehicleId = vehicleId;
            characterVehicle.ExpirationDate = expirationDate;

            repository.Update(characterVehicle);

            CharacterVehicle updatedCharacterVehicle = repository.GetOne(id);

            Assert.AreEqual(characterVehicle.Id, id);
            Assert.AreEqual(characterVehicle.CharacterId, characterId);
            Assert.AreEqual(characterVehicle.VehicleId, vehicleId);
            Assert.AreEqual(characterVehicle.ExpirationDate, expirationDate);
        }

        [Test]
        public void SelectAllCharacterVehicles()
        {
            CreateCharacterVehicle();

            Assert.Greater(repository.GetAll().Count(), 0);
        }

        [Test]
        public void DeleteCharacterVehicle()
        {
            CreateCharacterVehicle();

            int id = 1;

            repository.Delete(id);

            repository.Commit();

            CharacterVehicle deletedCharacterVehicle = repository.GetOne(id);

            Assert.IsNull(deletedCharacterVehicle);
        }

        [Test]
        public void Commit()
        {
            int id = 1;
            int characterId = 1;
            int vehicleId = 3;
            DateTimeOffset expirationDate = DateTimeOffset.UtcNow.AddDays(1);

            repository.Create(new CharacterVehicle
            {
                Id = id,
                CharacterId = characterId,
                VehicleId = vehicleId,
                ExpirationDate = expirationDate
            });

            Assert.IsNull(repository.GetOne(id));

            repository.Commit();

            Assert.IsNotNull(repository.GetOne(id));
        }

        [TearDown]
        public void TearDown()
        {
            if (repository.GetAll().Count() > 0)
            {
                repository.Delete(1);
                repository.Commit();
            }
        }
    }
}