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
                    movie.Characters.Select(mc => new BasicInfoViewModel
                    {
                        Id = mc.Id,
                        Name = mc.Name
                    }).ToList(),

                    movie.Planets.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    movie.Vehicles.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),
                    movie.Starships.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Id,
                        Name = x.Name
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
                    movie.Characters.Select(mc => new BasicInfoViewModel
                    {
                        Id = mc.Id,
                        Name = mc.Name
                    }).ToList(),

                    movie.Planets.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    movie.Vehicles.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),
                    movie.Starships.Select(x => new BasicInfoViewModel
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList()
                )).AsNoTracking().ToList();

            return result;
        }
    }
}
