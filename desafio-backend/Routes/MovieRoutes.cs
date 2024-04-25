using AutoMapper;
using desafio_backend.ViewModels.MovieViewModel;
using desafio_shared.Data;
using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;

namespace desafio_backend.Routes
{
    public static class MovieRoutes
    {
        public static WebApplication MapMovieRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();

            app.MapGet("/movie", (AppDbContext context) =>
            {
                //List<Movie> movies = GenerateFakeMovies();
                //List<Movie> movies = context.Movies.ToList();

                var result = context.Movies
                .SelectMany(
                    movie => context.MovieCharacters.Where(cm => cm.MovieId == movie.Id),
                    (movie, characterMovie) => new { Movie = movie, CharacterMovie = characterMovie })
                .SelectMany(
                    mc => context.Characters.Where(c => c.Id == mc.CharacterMovie.CharacterId),
                    (mc, character) => new
                    {
                        mc.Movie.Id,
                        mc.Movie.Title,
                        mc.Movie.Episode,
                        mc.Movie.OpeningCrawl,
                        mc.Movie.Director,
                        mc.Movie.Producer,
                        mc.Movie.ReleaseDate,
                        CharacterId = character.Id,
                        character.Name
                    })
                .ToList();

                var movies = context.Movies.ToList();

                List<MovieViewModel>? moviesViewModel = mapper?.Map<List<MovieViewModel>>(movies);
                return Results.Ok(moviesViewModel);

            }).Produces<List<MovieViewModel>>();
            return app;
        }

        public static List<Movie> GenerateFakeMovies()
        {
            return new List<Movie> {
            new Movie(1, "Movie 1", 1, "Opening crawl 1", "Director 1", "Producer 1", DateTime.Now),
            new Movie(2, "Movie 2", 2, "Opening crawl 2", "Director 2", "Producer 2", DateTime.Now),
            new Movie(3, "Movie 3", 3, "Opening crawl 3", "Director 3", "Producer 3", DateTime.Now),
        };

        }
    }
}
