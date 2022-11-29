﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetHero.Models;

namespace PetHero.Mappings
{
    public class TutorMap : IEntityTypeConfiguration<Tutor>
    {
        public void Configure(EntityTypeBuilder<Tutor> builder)
        {
            builder.Property(property => property.Name).IsRequired();
        }
    }
}