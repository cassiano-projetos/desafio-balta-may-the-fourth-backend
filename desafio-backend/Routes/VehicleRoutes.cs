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
            
            app.MapGet("/vehicle", (IVehicleService service, int id) =>
            {
                VehicleViewModel vehicle = service.GetVehicle(id);
                return Results.Ok(vehicle);

            }).Produces<VehicleViewModel>();

            app.MapGet("/vehicles", (IVehicleService service) =>
            {
                List<VehicleViewModel> vehicles = service.GetVehicles();
                return Results.Ok(vehicles);

            }).Produces<List<VehicleViewModel>>();
            return app;
        }
    }
}
