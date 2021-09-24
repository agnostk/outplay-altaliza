using Altaliza.Core.Entities;
using Altaliza.Core.Repositories;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class CategoryRepository : BaseEntityRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}