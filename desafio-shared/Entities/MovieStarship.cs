namespace desafio_shared.Entities;

public class MovieStarship
{
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }
    
    public int StarshipId { get; private set; }
    public Starship Starship { get; private set; }
}