using System;

namespace Altaliza.Core.Entities
{
    public class CharacterVehicle : BaseEntity
    {
        public Character Character { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}