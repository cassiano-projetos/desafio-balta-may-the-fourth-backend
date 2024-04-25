using desafio_shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace desafio_shared.Data;

public class AppDbContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Planet> Planets { get; set; }
    public DbSet<Starship> Starships { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<MoviePlanet> MoviePlanets { get; set; }
    public DbSet<MovieCharacter> MovieCharacters { get; set; }
    public DbSet<MovieStarship> MovieStarships { get; set; }
    public DbSet<MovieVehicle> MovieVehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=balta-desafio.db;Cache=Shared");
    
}