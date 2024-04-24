using AutoMapper;
using desafio_backend.ViewModels.MovieViewModel;
using desafio_shared.Entities;

namespace desafio_backend.Routes
{
    public static class MovieRoutes
    {
        public static WebApplication MapMovieRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();

            app.MapGet("/movie", () =>
            {
                List<Movie> movies = GenerateFakeMovies();
                List<MovieViewModel>? moviesViewModel = mapper?.Map<List<MovieViewModel>>(movies);
                return Results.Ok(moviesViewModel);

            }).Produces<List<MovieViewModel>>();
            return app;
        }

        public static List<Movie> GenerateFakeMovies()
        {
            return new List<Movie>
        {
            new Movie("Movie 1", 1, "Opening crawl 1", "Director 1", "Producer 1", DateTime.Now),
            new Movie("Movie 2", 2, "Opening crawl 2", "Director 2", "Producer 2", DateTime.Now),
            new Movie("Movie 3", 3, "Opening crawl 3", "Director 3", "Producer 3", DateTime.Now),
        };
        }
    }
}
