using Altaliza.Core.Entities;
using Altaliza.Core.Repositories;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class CharacterVehicleRepository : BaseEntityRepository<CharacterVehicle>, ICharacterVehicleRepository
    {
        public CharacterVehicleRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}