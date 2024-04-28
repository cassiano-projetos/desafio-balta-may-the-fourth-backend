using AutoMapper;
using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;
using desafio_shared.Entities;

namespace desafio_backend.Routes
{
    public static class CharacterRoutes
    {
        public static WebApplication MapCharacterRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();

            app.MapGet("/character", (ICharacterService service, int id) =>
            {
                CharacterViewModel character = service.GetCharacter(id);
                return Results.Ok(character);

            }).Produces<List<MovieViewModel>>();
            
            app.MapGet("/characters", (ICharacterService service) =>
            {
                List<CharacterViewModel> characters = service.GetCharacters();
                return Results.Ok(characters);

            }).Produces<List<MovieViewModel>>();
            return app;
        }
    }
}
