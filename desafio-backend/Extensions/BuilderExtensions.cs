using desafio_backend.Services;
using desafio_backend.Services.Interfaces;
using desafio_shared.Data;

namespace desafio_backend.Extensions
{
    public static class BuilderExtensions
    {
        public static void AddArchitectures(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();
            builder.Services.AddScoped<ICharacterService, CharacterService>();
            builder.Services.AddScoped<IPlanetService, PlanetService>();
        }
    }
}
