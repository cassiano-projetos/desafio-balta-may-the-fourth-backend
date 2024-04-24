using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_shared.Mapping;

public class CharacterMap : IEntityTypeConfiguration<Character>
{
    public void Configure(EntityTypeBuilder<Character> builder)
    {
        builder.ToTable("Character");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasMaxLength(100);

        builder.Property(x => x.Height)
            .HasMaxLength(10);

        builder.Property(x => x.Weight)
            .HasMaxLength(10);


    }
}