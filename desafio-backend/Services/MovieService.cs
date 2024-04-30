using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend.Services
{
    public class MovieService : IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context)
        {
            _context = context;
        }

        public MovieViewModel GetMovie(int id)
        {
            var result = _context.Movies.Where(x => x.Id == id)
                  .Select(movie => new MovieViewModel(
                    movie.Title,
                    movie.Episode,
                    movie.OpeningCrawl,
                    movie.Director,
                    movie.Producer,
                    movie.ReleaseDate,
                    movie.MovieCharacters.Select(mc => new BasicInfoViewModel
                    {
                        Id = mc.Character.Id,
                        Name = mc.Character.Name
                    }).ToList(),

                    movie.MoviePlanets.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Planet.Id,
                        Name = x.Planet.Name
                    }).ToList(),

                    movie.MovieVehicles.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Vehicle.Id,
                        Name = x.Vehicle.Name
                    }).ToList(),
                    movie.MovieStarships.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Starship.Id,
                        Name = x.Starship.Name
                    }).ToList()
                )).AsNoTracking().FirstOrDefault();

            return result;
        }

        public List<MovieViewModel> GetMovies()
        {
            var result = _context.Movies
                  .Select(movie => new MovieViewModel(
                    movie.Title,
                    movie.Episode,
                    movie.OpeningCrawl,
                    movie.Director,
                    movie.Producer,
                    movie.ReleaseDate,
                    movie.MovieCharacters.Select(mc => new BasicInfoViewModel
                    {
                        Id = mc.Character.Id,
                        Name = mc.Character.Name
                    }).ToList(),

                    movie.MoviePlanets.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Planet.Id,
                        Name = x.Planet.Name
                    }).ToList(),

                    movie.MovieVehicles.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Vehicle.Id,
                        Name = x.Vehicle.Name
                    }).ToList(),
                    movie.MovieStarships.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Starship.Id,
                        Name = x.Starship.Name
                    }).ToList()
                ))
                .AsNoTracking().ToList();

            return result;
        }
    }
}
