using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;

namespace desafio_backend.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly AppDbContext _context;

        public CharacterService(AppDbContext context)
        {
            _context = context;
        }
        
        public CharacterViewModel GetCharacter(int id)
        {
            var result = _context.Characters.Where(x=>x.Id == id)
                .Select(character => new CharacterViewModel(
                    character.Name,
                    character.Height,
                    character.Weight,
                    character.HairColor,
                    character.SkinColor,
                    character.EyeColor,
                    character.BirthYear,
                    character.Gender,
                    new BasicInfoViewModel { Id = character.Planet.Id, Name = character.Planet.Name },
                    character.MovieCharacters.Select(mv => new BasicMovieInfoViewModel
                    {
                        Id = mv.Movie.Id,
                        Title = mv.Movie.Title
                    }).ToList()
                ))
                .FirstOrDefault();

            return result;
        }
        

        public List<CharacterViewModel> GetCharacters()
        {
            var result = _context.Characters.Select(character => new CharacterViewModel(
                character.Name,
                character.Height,
                character.Weight,
                character.HairColor,
                character.SkinColor,
                character.EyeColor,
                character.BirthYear,
                character.Gender,
                new BasicInfoViewModel { Id = character.Planet.Id, Name = character.Planet.Name },
                character.MovieCharacters.Select(mv => new BasicMovieInfoViewModel
                {
                    Id = mv.Movie.Id,
                    Title = mv.Movie.Title
                }).ToList()
                ))
                .ToList();

            return result;
        }
    }
}
