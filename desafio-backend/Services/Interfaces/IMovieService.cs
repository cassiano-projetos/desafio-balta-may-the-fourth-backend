using desafio_backend.ViewModels.MovieViewModel;

namespace desafio_backend.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieViewModel> GetMovies();
    }
}
