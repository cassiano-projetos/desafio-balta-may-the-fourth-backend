using desafio_backend.Services.Interfaces;
using desafio_backend.ViewModels;
using desafio_shared.Data;
using Microsoft.EntityFrameworkCore;

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
            var result = _context.Vehicles.Where(x => x.Id == id)
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
                    vehicle.Movies.Select(mv => new BasicMovieInfoViewModel
                    {
                        Id = mv.Id,
                        Title = mv.Title
                    }).ToList()
                )).AsNoTracking().FirstOrDefault();

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
                vehicle.Movies.Select(mv => new BasicMovieInfoViewModel
                {
                    Id = mv.Id,
                    Title = mv.Title
                }).ToList()
            )).AsNoTracking().ToList();

            return result;
        }
    }
}

