using Altaliza.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altaliza.DAL.Constraints
{
    public class VehicleConstraints : BaseEntityConstraints<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);

            builder.Property(vehicle => vehicle.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(vehicle => vehicle.Price1Day)
                .IsRequired();

            builder.Property(vehicle => vehicle.Price7Days)
                .IsRequired();

            builder.Property(vehicle => vehicle.Price15Days)
                .IsRequired();

            builder.Property(vehicle => vehicle.Stock)
                .IsRequired();
        }
    }
}