using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_shared.Mapping
{
    internal class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasColumnName("Title")
                .HasMaxLength(100);

            builder.Property(x => x.Episode)
                .HasColumnName("Episode")
                .HasMaxLength(4);
                

            builder.Property(x => x.OpeningCrawl)
                .HasColumnName("Opening_Crawl")
                .HasMaxLength(7000);

            builder.Property(x => x.Director)
                .HasColumnName("Director")
                .HasMaxLength(100);

            builder.Property(x => x.Producer)
                .HasColumnName("Producer")
                .HasMaxLength(100);

            builder.Property(x => x.ReleaseDate)
                .HasColumnName("ReleaseDate")
                .HasMaxLength(100);


            //Relationship


            builder.HasMany(x => x.Characters);
            builder.HasMany(x => x.Starships);
            builder.HasMany(x => x.Planets);
            builder.HasMany(x => x.Vehicles);


        }
    }
}
