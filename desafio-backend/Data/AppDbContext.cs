using desafio_shared.Entities;
using desafio_shared.Mapping;
using Microsoft.EntityFrameworkCore;

namespace desafio_shared.Data;

public class AppDbContext : DbContext
{
    public DbSet<Character> Characters { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Planet> Planets { get; set; }
    public DbSet<Starship> Starships { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=balta-desafio.db;Cache=Shared")
            .LogTo(Console.WriteLine, LogLevel.Information);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CharacterMap());
        modelBuilder.ApplyConfiguration(new MovieMap());
        modelBuilder.ApplyConfiguration(new PlanetMap());
        modelBuilder.ApplyConfiguration(new StarshipMap());
        modelBuilder.ApplyConfiguration(new VehicleMap());
    }
}