using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_shared.Mapping;

public class StarshipMap : IEntityTypeConfiguration<Starship>
{
    public void Configure(EntityTypeBuilder<Starship> builder)
    {
        builder.ToTable("Starships");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100);
        
        builder.Property(x => x.Model)
            .HasColumnName("Model")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(15);
        
        builder.Property(x => x.Manufacturer)
            .HasColumnName("Manufacturer")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.CostInCredits)
            .HasColumnName("CostInCredits")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.Length)
            .HasColumnName("Length")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.MaxSpeed)
            .HasColumnName("MaxSpeed")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.Crew)
            .HasColumnName("Crew")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.Passengers)
            .HasColumnName("Passengers")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.CargoCapacity)
            .HasColumnName("CargoCapacity")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.CargoCapacity)
            .HasColumnName("CargoCapacity")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.HyperdriveRating)
            .HasColumnName("HyperdriveRating")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.Mglt)
            .HasColumnName("Mglt")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(10);
        
        builder.Property(x => x.Consumables)
            .HasColumnName("Consumables")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x => x.Class)
            .HasColumnName("Class")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);

        builder.HasMany(m => m.Movies)
            .WithMany(s => s.Starships)
            .UsingEntity<MovieStarship>();
    }
}