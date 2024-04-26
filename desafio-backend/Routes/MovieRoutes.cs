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

                var resultado = context.Movies
                    .Include(movie => movie.MovieCharacters)
                        .ThenInclude(mc => mc.Character)
                    .Include(planet => planet.MoviePlanets)
                        .ThenInclude(mp => mp.Planet)
                    .Include(vehicle => vehicle.MovieVehicles)
                        .ThenInclude(mv => mv.Vehicle)
                    .Include(starship => starship.MovieStarships)
                        .ThenInclude(ms => ms.Starship)
                    .Select(movie => new
                    {                        
                        Title = movie.Title,
                        Episode = movie.Episode,
                        OpeningCrawl = movie.OpeningCrawl,
                        Director = movie.Director,
                        Producer = movie.Producer,
                        ReleaseDate = movie.ReleaseDate,
                        
                        Characters = movie.MovieCharacters.Select(mc => new
                        {
                            Id = mc.Character.Id,
                            Name = mc.Character.Name
                        }).ToList(),

                        Planets = movie.MoviePlanets.Select(x => new
                        {
                            Id = x.Planet.Id,
                            Name = x.Planet.Name
                        }).ToList(),

                        Vehicles = movie.MovieVehicles.Select(x => new
                        {
                            Id = x.Vehicle.Id,
                            Name = x.Vehicle.Name
                        }).ToList(),

                        StarShips = movie.MovieStarships.Select(x => new
                        {
                            Id = x.Starship.Id,
                            Name = x.Starship.Name
                        }).ToList()
                    })
                    .ToList();                

                //List<MovieViewModel>? moviesViewModel = mapper?.Map<List<MovieViewModel>>(resultado);
                return Results.Ok(resultado);

            }).Produces<List<MovieViewModel>>();
            return app;
        }
    }
}
