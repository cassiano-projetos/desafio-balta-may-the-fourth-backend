using desafio_backend.ViewModels;

namespace desafio_backend.Services.Interfaces;

public interface IStarshipService
{
    StarshipViewModel GetStarShip(int id);
    
    List<StarshipViewModel> GetStarShips();
}