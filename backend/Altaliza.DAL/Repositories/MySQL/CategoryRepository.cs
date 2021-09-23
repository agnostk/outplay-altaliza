using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class CategoryRepository : BaseEntityRepository<Category>
    {
        public CategoryRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}