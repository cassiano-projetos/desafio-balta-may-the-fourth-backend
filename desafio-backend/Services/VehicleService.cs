using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;

namespace desafio_backend.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly AppDbContext _context;

        public VehicleService(AppDbContext context)
        {
            _context = context;
        }

        public VehicleViewModel GetVehicle(int id)
        {
            var result = _context.Vehicles.Where(x=>x.Id == id)
                .Select(vehicle => new VehicleViewModel(
                    vehicle.Name,
                    vehicle.Model,
                    vehicle.Manufacturer,
                    vehicle.CostInCredits,
                    vehicle.Length,
                    vehicle.MaxSpeed,
                    vehicle.Crew,
                    vehicle.Passengers,
                    vehicle.CargoCapacity,
                    vehicle.Consumables,
                    vehicle.Class,
                    vehicle.MovieVehicles.Select(mv => new BasicMovieInfoViewModel
                    {
                        Id = mv.Movie.Id,
                        Title = mv.Movie.Title
                    }).ToList()
                ))
                .FirstOrDefault();

            return result;
        }

        public List<VehicleViewModel> GetVehicles()
        {
            var result = _context.Vehicles
            .Select(vehicle => new VehicleViewModel(
                vehicle.Name,
                vehicle.Model,
                vehicle.Manufacturer,
                vehicle.CostInCredits,
                vehicle.Length,
                vehicle.MaxSpeed,
                vehicle.Crew,
                vehicle.Passengers,
                vehicle.CargoCapacity,
                vehicle.Consumables,
                vehicle.Class,
                vehicle.MovieVehicles.Select(mv => new BasicMovieInfoViewModel
                {
                    Id = mv.Movie.Id,
                    Title = mv.Movie.Title
                }).ToList()
                ))
                .ToList();

            return result;
        }
    }
}

