using Altaliza.Core.Entities;

namespace Altaliza.App.Dtos
{
    public record VehicleDto(
        int Id,
        int CategoryId,
        string Name,
        int Stock,
        string Image,
        decimal Price1Day,
        decimal Price7Days,
        decimal Price15Days
    );
}