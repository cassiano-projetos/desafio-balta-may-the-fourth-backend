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
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100);

        builder.Property(x => x.Height)
            .HasColumnName("Height")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.Weight)
            .HasColumnName("Weight")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.HairColor)
            .HasColumnName("HairColor")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.SkinColor)
            .HasColumnName("SkinColor")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.EyeColor)
            .HasColumnName("EyeColor")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.BirthYear)
            .HasColumnName("BirthYear")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        builder.Property(x => x.Gender)
            .HasColumnName("Gender")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);

        
        //Relantionship
        
        builder.HasIndex(x => x.Planet, "IX_Character_Planet")
            .IsUnique();

        builder.HasOne(p => p.Planet)
            .WithOne(c => c.Character)
            .HasForeignKey<Planet>(p=>p.CharacterId);
        
        builder.HasMany(m => m.Movies)
            .WithOne(p => p.Character)
            .HasForeignKey(p => p.CharacterId);

    }
}