namespace desafio_shared.Entities;

public abstract class Entity
{
    public int Id { get; private set;}

    public Entity(int id)
    {
        Id = id;
    }
}