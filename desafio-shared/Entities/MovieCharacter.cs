namespace desafio_shared.Entities;

public class MovieCharacter
{
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }
    
    public int CharacterId { get; private set; }
    public Character Character { get; private set; }
}   