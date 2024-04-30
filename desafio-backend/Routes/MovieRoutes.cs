using AutoMapper;
using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Entities;

namespace desafio_backend.Routes
{
    public static class MovieRoutes
    {
        public static WebApplication MapMovieRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();
            
            app.MapGet("/movie", (IMovieService service, int id) =>
            {
                try
                {
                    MovieViewModel movies = service.GetMovie(id);
                    return Results.Ok(movies);
                }
                catch (Exception e)
                {
                    return Results.BadRequest(e.Message);
                }

            }).Produces<MovieViewModel>();

            app.MapGet("/movies", (IMovieService service) =>
            {
                List<MovieViewModel> movies = service.GetMovies();
                return Results.Ok(movies);

            }).Produces<List<MovieViewModel>>();

            return app;
        }
    }
}
