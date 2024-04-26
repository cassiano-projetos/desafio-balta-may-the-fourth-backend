using desafio_backend.ViewModels;

namespace desafio_backend.Services.Interfaces
{
    public interface IMovieService
    {
        MovieViewModel GetMovie(int id);
        List<MovieViewModel> GetMovies();
    }
}
