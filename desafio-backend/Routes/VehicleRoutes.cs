using AutoMapper;
using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;

namespace desafio_backend.Routes
{
    public static class VehicleRoutes
    {
        public static WebApplication MapVehicleRoutes(this WebApplication app)
        {
            var mapper = app.Services.GetService<IMapper>();

            app.MapGet("/vehicles", (IVehicleService service) =>
            {
                List<VehicleViewModel> vehicles = service.GetVehicles();
                return Results.Ok(vehicles);

            }).Produces<List<VehicleViewModel>>();
            return app;
        }
    }
}
