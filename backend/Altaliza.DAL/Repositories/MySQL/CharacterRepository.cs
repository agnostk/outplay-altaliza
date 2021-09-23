using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class CharacterRepository : BaseEntityRepository<Character>
    {
        public CharacterRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}