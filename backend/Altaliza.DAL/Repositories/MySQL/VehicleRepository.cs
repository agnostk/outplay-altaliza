using Altaliza.Core.Entities;
using Altaliza.Core.Repositories;
using Altaliza.DAL.Contexts;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class VehicleRepository : BaseEntityRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(MySQLContext appDbContext) : base(appDbContext) { }
    }
}