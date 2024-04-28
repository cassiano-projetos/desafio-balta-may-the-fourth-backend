using desafio_backend.ViewModels;

namespace desafio_backend.Services.Interfaces
{
    public interface ICharacterService
    {
        CharacterViewModel GetCharacter(int id);

        List<CharacterViewModel> GetCharacters();
    }
}
