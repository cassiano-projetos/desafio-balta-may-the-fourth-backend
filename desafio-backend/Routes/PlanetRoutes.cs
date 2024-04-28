using AutoMapper;
using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;

namespace desafio_backend.Routes
{
    public static class PlanetRoutes
    {
        public static WebApplication MapPlanetRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();

            app.MapGet("/planet", (IPlanetService service, int id) =>
            {
                PlanetViewModel planet = service.GetPlanet(id);
                return Results.Ok(planet);
            }).Produces<PlanetViewModel>();
            
            app.MapGet("/planets", (IPlanetService service) =>
            {
                List<PlanetViewModel> planets = service.GetPlanets();
                return Results.Ok(planets);
            }).Produces<List<PlanetViewModel>>();
            
            return app;
        }
    }
}
