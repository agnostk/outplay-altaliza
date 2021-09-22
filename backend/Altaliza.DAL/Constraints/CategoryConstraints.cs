using Altaliza.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altaliza.DAL.Constraints
{
    public class CategoryConstraints : BaseEntityConstraints<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(category => category.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(category => category.Description)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}