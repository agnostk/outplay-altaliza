using System.Collections.Generic;

namespace Altaliza.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}