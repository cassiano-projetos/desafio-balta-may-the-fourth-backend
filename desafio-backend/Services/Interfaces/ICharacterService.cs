using desafio_backend.ViewModels;

namespace desafio_backend.Services.Interfaces
{
    public interface ICharacterService
    {
        List<CharacterViewModel> GetCharacters();
    }
}
