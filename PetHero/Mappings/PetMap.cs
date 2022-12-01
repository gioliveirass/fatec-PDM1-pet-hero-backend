using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHero.Models;

namespace PetHero.Mappings
{
    public class PetMap : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.Property(property => property.Name).IsRequired();
            builder.Property(property => property.Gender).IsRequired();
            builder.Property(property => property.Type).IsRequired();
            builder.Property(property => property.Birthday).IsRequired();
        }
    }
}
