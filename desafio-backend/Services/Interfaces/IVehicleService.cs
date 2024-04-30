using desafio_backend.ViewModels;

namespace desafio_backend.Services.Interfaces
{
    public interface IVehicleService
    {
        
        VehicleViewModel GetVehicle(int id);

        List<VehicleViewModel> GetVehicles();

    }
}
