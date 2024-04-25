namespace desafio_shared.Entities;

public class MovieVehicle
{
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }
    
    public int VehicleId { get; private set; }
    public Vehicle Vehicle { get; private set; }
}