using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend.Services;

public class PlanetService : IPlanetService
{
    private readonly AppDbContext _context;

    public PlanetService(AppDbContext context)
    {
        _context = context;
    }
    
    public PlanetViewModel GetPlanet(int id)
    {
        var result = _context.Planets.Where(x => x.Id == id)
            .Select(planet => new PlanetViewModel(
                planet.Name,
                planet.RotationPeriod,
                planet.OrbitalPeriod,
                planet.Diameter,
                planet.Climate,
                planet.Gravity,
                planet.Terrain,
                planet.SurfaceWater,
                planet.Population,
                planet.Characters.Select(c => new BasicInfoViewModel
                {
                    Id = c.Id,
                    Name = c.Name

                }).ToList(),
                planet.MoviePlanets.Select(m => new BasicMovieInfoViewModel
                {
                    Id = m.Movie.Id,
                    Title = m.Movie.Title

                }).ToList()
            )).AsNoTracking().FirstOrDefault();
        
        return result;
    }
    
    public List<PlanetViewModel> GetPlanets()
    {
        var result = _context.Planets.Select(planet => new PlanetViewModel(
            planet.Name,
            planet.RotationPeriod,
            planet.OrbitalPeriod,
            planet.Diameter,
            planet.Climate,
            planet.Gravity,
            planet.Terrain,
            planet.SurfaceWater,
            planet.Population,
            planet.Characters.Select(c => new BasicInfoViewModel
            {
                Id = c.Id,
                Name = c.Name

            }).ToList(),
            planet.MoviePlanets.Select(m=>new BasicMovieInfoViewModel
            {
                Id = m.Movie.Id,
                Title = m.Movie.Title
                    
            }).ToList()
        )).AsNoTracking().ToList();
        
        return result;
    }
}