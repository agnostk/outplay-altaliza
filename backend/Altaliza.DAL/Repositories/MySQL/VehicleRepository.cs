using Altaliza.Core.Entities;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class VehicleRepository : BaseEntityRepository<Vehicle>
    {
        public VehicleRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}