using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_shared.Mapping;

public class PlanetMap : IEntityTypeConfiguration<Planet>
{

    public void Configure(EntityTypeBuilder<Planet> builder)
    {
        builder.ToTable("Planets");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(100);
        
        builder.Property(x=>x.RotationPeriod)
            .HasColumnName("RotationPeriod")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.OrbitalPeriod)
            .HasColumnName("OrbitalPeriod")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.Diameter)
            .HasColumnName("Diameter")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.Climate)
            .HasColumnName("Climate")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.Gravity)
            .HasColumnName("Gravity")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.Gravity)
            .HasColumnName("Gravity")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.Terrain)
            .HasColumnName("Terrain")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.SurfaceWater)
            .HasColumnName("SurfaceWater")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(50);
        
        builder.Property(x=>x.Population)
            .HasColumnName("Population")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(15);
        
        builder.HasMany(c => c.Characters)
            .WithOne(p => p.Planet)
            .HasForeignKey(p => p.PlanetId);

        builder.HasMany(m => m.Movies)
            .WithMany(p => p.Planets);
    }
    
}