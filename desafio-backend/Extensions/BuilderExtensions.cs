using desafio_backend.Services;
using desafio_backend.Services.Interfaces;
using desafio_shared.Data;
using Microsoft.OpenApi.Models;

namespace desafio_backend.Extensions
{
    public static class BuilderExtensions
    {
        public static void AddArchitectures(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "May the Fourth", Version = "v1" });
            });
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddScoped<IMovieService, MovieService>();
            builder.Services.AddScoped<IVehicleService, VehicleService>();
            builder.Services.AddScoped<ICharacterService, CharacterService>();
            builder.Services.AddScoped<IPlanetService, PlanetService>();
            builder.Services.AddScoped<IStarshipService, StarshipService>();
        }
    }
}
