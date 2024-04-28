namespace desafio_shared.Entities;

public class MoviePlanet
{
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }
    
    public int PlanetId { get; private set; }
    public Planet Planet { get; private set; }
}