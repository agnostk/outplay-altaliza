using Altaliza.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Altaliza.DAL.Constraints
{
    public class CharacterConstraints : BaseEntityConstraints<Character>
    {
        public override void Configure(EntityTypeBuilder<Character> builder)
        {
            base.Configure(builder);

            builder
                .Property(character => character.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(character => character.Wallet)
                .IsRequired()
                .HasPrecision(12, 2);
        }
    }
}