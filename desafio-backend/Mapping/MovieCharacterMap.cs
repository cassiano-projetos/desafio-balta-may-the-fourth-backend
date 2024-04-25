using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend.Mapping
{
    public class MovieCharacterMap : IEntityTypeConfiguration<MovieCharacter>
    {
        public void Configure(EntityTypeBuilder<MovieCharacter> builder)
        {
            builder.ToTable("CharacterMovie");

            builder.HasKey(mc => new
            {
                mc.MovieId,
                mc.CharacterId
            });

        }
    }
}
