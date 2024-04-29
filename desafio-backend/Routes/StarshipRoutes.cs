using AutoMapper;
using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;

namespace desafio_backend.Routes
{
    public static class StarshipRoutes
    {
       public static WebApplication MapStarshipRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();
            
            app.MapGet("/starship", (IStarshipService service, int id) =>
            {
                StarshipViewModel starship = service.GetStarShip(id);
                return Results.Ok(starship);
            }).Produces<StarshipViewModel>();
            
            app.MapGet("/starships", (IStarshipService service) =>
            {
                List<StarshipViewModel> starships = service.GetStarShips();
                return Results.Ok(starships);
            }).Produces<List<StarshipViewModel>>();
           return app;
        }
    }
}
