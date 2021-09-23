using System.Linq;
using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;
using Altaliza.DAL.Repositories.MySQL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Altaliza.DAL.Tests.Repositories.MySQL
{
    [TestFixture]
    public class CharacterRepositoryTests
    {
        private MySQLContext context;
        private CharacterRepository repository;

        [SetUp]
        public void Setup()
        {
            string mySqlConnection = "server=localhost;user=root;password=root;database=altaliza;";
            context = new MySQLContext(
                new DbContextOptionsBuilder<MySQLContext>()
                    .UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)
                ).Options
            );

            repository = new CharacterRepository(context);
        }

        [Test]
        public void SelectCharacter()
        {
            int id = 1;

            Character character = repository.GetOne(id);

            Assert.AreEqual(character.Id, id);
            Assert.AreEqual(character.Name, "Fulano de Tal");
        }

        [Test]
        public void CreateCharacter()
        {
            int id = 2;
            string name = "Beltrano";
            decimal wallet = 15000m;

            repository.Create(new Character { Id = id, Name = name, Wallet = wallet });
            repository.Commit();

            Character createdCharacter = repository.GetOne(id);

            Assert.AreEqual(createdCharacter.Id, id);
            Assert.AreEqual(createdCharacter.Name, name);
            Assert.AreEqual(createdCharacter.Wallet, wallet);
        }

        [Test]
        public void UpdateCharacter()
        {
            CreateCharacter();

            int id = 2;
            string name = "Sicrano";
            decimal wallet = 123456m;

            Character character = repository.GetOne(id);

            character.Name = name;
            character.Wallet = wallet;

            repository.Update(character);

            Character updatedCharacter = repository.GetOne(id);

            Assert.AreEqual(updatedCharacter.Id, id);
            Assert.AreEqual(updatedCharacter.Name, name);
            Assert.AreEqual(updatedCharacter.Wallet, wallet);
        }

        [Test]
        public void SelectAllCharacters()
        {
            CreateCharacter();
            Assert.Greater(repository.GetAll().Count(), 1);
        }

        [Test]
        public void DeleteCharacter()
        {
            CreateCharacter();

            int id = 2;

            repository.Delete(id);

            repository.Commit();

            Character deletedCharacter = repository.GetOne(id);

            Assert.IsNull(deletedCharacter);
        }

        [Test]
        public void Commit()
        {
            int id = 2;
            string name = "Sicrano";
            decimal wallet = 12434m;

            repository.Create(new Character { Id = id, Name = name, Wallet = wallet });

            Assert.IsNull(repository.GetOne(id));

            repository.Commit();

            Assert.IsNotNull(repository.GetOne(id));
        }

        [TearDown]
        public void TearDown()
        {
            if (repository.GetAll().Count() > 1)
            {
                repository.Delete(2);
                repository.Commit();
            }
        }
    }
}