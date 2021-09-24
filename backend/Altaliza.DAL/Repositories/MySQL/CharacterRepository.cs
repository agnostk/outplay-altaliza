using Altaliza.Core.Entities;
using Altaliza.Core.Repositories;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class CharacterRepository : BaseEntityRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}