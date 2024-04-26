using AutoMapper;
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

            app.MapGet("/character", (AppDbContext context) => {
                var character = context.Characters.ToList();
                List<CharacterViewModel>? characterViewModel = mapper?.Map<List<CharacterViewModel>>(character);
                return Results.Ok(characterViewModel);
            }).Produces<List<CharacterViewModel>>(); ;
            return app;
        }

        public static List<Character> GenerateFakeCharacter()
        {
            return new List<Character> {
            new Character(1, "Character 1","", "Character crawl 1", "Character 1", "Character 1", "", "", ""),
            new Character(2, "Character 2","", "Character crawl 2", "Character 2", "Character 2", "", "", ""),
            new Character(3, "Character 3","", "Character crawl 3", "Character 3", "Character 3", "", "", "")
        };

        }
    }
}
