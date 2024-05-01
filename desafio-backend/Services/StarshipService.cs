using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend.Services;

public class StarshipService : IStarshipService
{
    private readonly AppDbContext _context;

    public StarshipService(AppDbContext context)
    {
        _context = context;
    }
    
    public StarshipViewModel GetStarShip(int id)
    {
        var result = _context.Starships
            .Where(x=>x.Id == id).Select(starship => 
            new StarshipViewModel(
            starship.Name,
            starship.Model,
            starship.Manufacturer,
            starship.CostInCredits,
            starship.Length,
            starship.MaxSpeed,
            starship.Crew,
            starship.Passengers,
            starship.CargoCapacity,
            starship.HyperdriveRating,
            starship.Mglt,
            starship.Consumables,
            starship.Class,
            starship.Movies.Select(ms => new BasicMovieInfoViewModel
            {
                Id = ms.Id,
                Title = ms.Title
            }).ToList()
        )).AsNoTracking().FirstOrDefault();

        return result;
    }

    public List<StarshipViewModel> GetStarShips()
    {
        var result = _context.Starships.Select(starship => 
        new StarshipViewModel(
            starship.Name,
            starship.Model,
            starship.Manufacturer,
            starship.CostInCredits,
            starship.Length,
            starship.MaxSpeed,
            starship.Crew,
            starship.Passengers,
            starship.CargoCapacity,
            starship.HyperdriveRating,
            starship.Mglt,
            starship.Consumables,
            starship.Class,
            starship.Movies.Select(ms => new BasicMovieInfoViewModel
            {
                Id = ms.Id,
                Title = ms.Title
            }).ToList()
        )).AsNoTracking().ToList();
        return result;
    }
}