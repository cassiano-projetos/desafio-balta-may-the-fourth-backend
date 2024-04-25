using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio_shared.Entities;

public class MovieCharacter
{
    [Key, Column(Order = 1)]
    public int MovieId { get; private set; }
    public Movie Movie { get; private set; }
    [Key, Column(Order = 2)]
    public int CharacterId { get; private set; }
    public Character Character { get; private set; }
}   