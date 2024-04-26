using desafio_backend.ViewModels.MovieViewModel;
using desafio_shared.Data;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend.Services.Interfaces
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context)
        {
            _context = context;
        }

        public List<MovieViewModel> GetMovies()
        {
            var result = _context.Movies
                .Include(movie => movie.MovieCharacters)
                    .ThenInclude(mc => mc.Character)
                .Include(planet => planet.MoviePlanets)
                    .ThenInclude(mp => mp.Planet)
                .Include(vehicle => vehicle.MovieVehicles)
                    .ThenInclude(mv => mv.Vehicle)
                .Include(starship => starship.MovieStarships)
                    .ThenInclude(ms => ms.Starship)
                .Select(movie => new MovieViewModel
                {
                    Title = movie.Title,
                    Episode = movie.Episode,
                    OpeningCrawl = movie.OpeningCrawl,
                    Director = movie.Director,
                    Producer = movie.Producer,
                    ReleaseDate = movie.ReleaseDate,

                    Characters = movie.MovieCharacters.Select(mc => new BasicInfoViewModel
                    {
                        Id = mc.Character.Id,
                        Name = mc.Character.Name
                    }).ToList(),

                    Planets = movie.MoviePlanets.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Planet.Id,
                        Name = x.Planet.Name
                    }).ToList(),

                    Vehicles = movie.MovieVehicles.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Vehicle.Id,
                        Name = x.Vehicle.Name
                    }).ToList(),

                    Starships = movie.MovieStarships.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Starship.Id,
                        Name = x.Starship.Name
                    }).ToList()
                })
                .ToList();

            return result;
        }
    }
}
