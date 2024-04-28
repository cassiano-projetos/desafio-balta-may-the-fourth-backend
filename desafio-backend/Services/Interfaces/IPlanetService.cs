using desafio_backend.ViewModels;

namespace desafio_backend.Services.Interfaces;

public interface IPlanetService
{
    PlanetViewModel GetPlanet(int id);
    List<PlanetViewModel> GetPlanets();
}