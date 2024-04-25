using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_shared.Mapping
{
    public class VehicleMap : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable(nameof(Vehicle));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(50);

            builder.Property(x => x.Model)
                .HasMaxLength(50);

            builder.Property(x => x.Manufacturer)
                .HasMaxLength(50);

            builder.Property(x => x.CostInCredits)
                .HasMaxLength(50);

            builder.Property(x => x.Length)
                .HasMaxLength(50);

            builder.Property(x => x.MaxSpeed)
                .HasMaxLength(50);

            builder.Property(x => x.Crew)
                .HasMaxLength(50);

            builder.Property(x => x.Passengers)
                .HasMaxLength(50);

            builder.Property(x => x.CargoCapacity)
                .HasMaxLength(50);

            builder.Property(x => x.Consumables)
                .HasMaxLength(50);

            builder.Property(x => x.Class)
                .HasMaxLength(50);


            //RELATIONSHIP

            builder.HasMany(x => x.Movies);
        }
    }
}