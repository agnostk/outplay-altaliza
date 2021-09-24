using Altaliza.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altaliza.DAL.Constraints
{
    public class VehicleConstraints : BaseEntityConstraints<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);

            builder
                .Property(vehicle => vehicle.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .HasOne(vehicle => vehicle.Category)
                .WithMany(category => category.Vehicles)
                .HasForeignKey(vehicle => vehicle.CategoryId);

            builder
                .Property(vehicle => vehicle.Price1Day)
                .HasPrecision(12, 2)
                .IsRequired();

            builder
                .Property(vehicle => vehicle.Price7Days)
                .HasPrecision(12, 2)
                .IsRequired();

            builder
                .Property(vehicle => vehicle.Price15Days)
                .HasPrecision(12, 2)
                .IsRequired();

            builder
                .Property(vehicle => vehicle.Stock)
                .IsRequired();
        }
    }
}