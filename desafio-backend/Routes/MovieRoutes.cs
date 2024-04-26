using AutoMapper;
using desafio_backend.ViewModels.MovieViewModel;
using desafio_shared.Data;
using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;
using desafio_backend.Services.Interfaces;

namespace desafio_backend.Routes
{
    public static class MovieRoutes
    {
        public static WebApplication MapMovieRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();

            app.MapGet("/movie", (IMovieService service) =>
            {
                List<MovieViewModel> movies = service.GetMovies();
                return Results.Ok(movies);

            }).Produces<List<MovieViewModel>>();
            return app;
        }
    }
}
