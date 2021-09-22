using System.Collections.Generic;

namespace Altaliza.Core.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }
        public decimal Wallet { get; set; }
        public List<CharacterVehicle> Vehicles { get; set; }
    }
}