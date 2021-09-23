using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class CharacterVehicleRepository : BaseEntityRepository<CharacterVehicle>
    {
        public CharacterVehicleRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}