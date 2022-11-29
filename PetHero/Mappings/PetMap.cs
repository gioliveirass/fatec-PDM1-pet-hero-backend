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
            builder.Property(property => property.DateOfCreation).IsRequired();

            builder.HasOne(property => property.Tutor)
                .WithMany(property => property.Pets)
                .HasForeignKey(property => property.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
