using System.Collections.Generic;

namespace Altaliza.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public decimal Price1Day { get; set; }
        public decimal Price7Days { get; set; }
        public decimal Price15Days { get; set; }
        public List<CharacterVehicle> CharacterVehicles { get; set; }
    }
}