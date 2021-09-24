using Altaliza.App.Dtos;
using Altaliza.Core.Entities;

namespace Altaliza.App.Extensions
{
    public static class Extensions
    {
        public static VehicleDto AsDto(this Vehicle vehicle)
        {
            return new VehicleDto(
                vehicle.Id,
                vehicle.CategoryId,
                vehicle.Name,
                vehicle.Stock,
                vehicle.Image,
                vehicle.Price1Day,
                vehicle.Price7Days,
                vehicle.Price15Days
            );
        }
    }
}