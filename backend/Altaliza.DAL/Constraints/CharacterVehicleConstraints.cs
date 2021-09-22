using Altaliza.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altaliza.DAL.Constraints
{
    public class CharacterVehicleConstraints : BaseEntityConstraints<CharacterVehicle>
    {
        public override void Configure(EntityTypeBuilder<CharacterVehicle> builder)
        {
            base.Configure(builder);

            builder
                .Property(characterVehicle => characterVehicle.ExpirationDate)
                .IsRequired();

            builder
                .HasOne(characterVehicle => characterVehicle.Character)
                .WithMany(character => character.Vehicles)
                .IsRequired();

            builder
                .HasOne(characterVehicle => characterVehicle.Vehicle)
                .WithMany(vehicle => vehicle.CharacterVehicles)
                .IsRequired();
        }
    }
}