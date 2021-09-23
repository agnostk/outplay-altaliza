using System;

namespace Altaliza.Core.Entities
{
    public class CharacterVehicle : BaseEntity
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}