using System.Linq;
using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;
using Altaliza.DAL.Repositories.MySQL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Altaliza.Core.Tests.Repositories.MySQL
{
    [TestFixture]
    public class CategoryRepositoryTests
    {
        private MySQLContext context;
        private CategoryRepository repository;

        [SetUp]
        public void Setup()
        {
            string mySqlConnection = "server=localhost;user=root;password=root;database=altaliza;";
            context = new MySQLContext(
                new DbContextOptionsBuilder<MySQLContext>()
                    .UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)
                ).Options
            );

            repository = new CategoryRepository(context);
        }

        [Test]
        public void SelectCategory()
        {
            int id = 1;

            Category category = repository.GetOne(id);

            Assert.AreEqual(category.Id, id);
            Assert.AreEqual(category.Name, "Commercial");
            Assert.AreEqual(category.Description, "Comerciais");
        }

        [Test]
        public void CreateCategory()
        {
            int id = 11;
            string name = "Teste";
            string description = "Categoria Teste";

            repository.Create(new Category { Id = id, Name = name, Description = description });
            repository.Commit();

            Category createdCategory = repository.GetOne(id);

            Assert.AreEqual(createdCategory.Id, id);
            Assert.AreEqual(createdCategory.Name, name);
            Assert.AreEqual(createdCategory.Description, description);
        }

        [Test]
        public void UpdateCategory()
        {
            CreateCategory();

            int id = 11;
            string name = "Teste";
            string description = "Categoria Teste";

            Category category = repository.GetOne(id);

            category.Name = name;
            category.Description = description;

            repository.Update(category);

            Category updatedCategory = repository.GetOne(id);

            Assert.AreEqual(updatedCategory.Id, id);
            Assert.AreEqual(updatedCategory.Name, name);
            Assert.AreEqual(updatedCategory.Description, description);
        }

        [Test]
        public void SelectAllCategories()
        {
            CreateCategory();
            Assert.Greater(repository.GetAll().Count(), 10);
        }

        [Test]
        public void DeleteCategory()
        {
            CreateCategory();

            int id = 11;

            repository.Delete(id);

            repository.Commit();

            Category deletedCategory = repository.GetOne(id);

            Assert.IsNull(deletedCategory);
        }

        [Test]
        public void Commit()
        {
            int id = 11;
            string name = "Teste";
            string description = "Categoria Teste";

            repository.Create(new Category { Id = id, Name = name, Description = description });

            Assert.IsNull(repository.GetOne(id));

            repository.Commit();

            Assert.IsNotNull(repository.GetOne(id));
        }

        [TearDown]
        public void TearDown()
        {
            if (repository.GetAll().Count() > 10)
            {
                repository.Delete(11);
                repository.Commit();
            }
        }
    }
}