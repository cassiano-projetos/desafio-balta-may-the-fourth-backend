namespace desafio_shared.Entities
{
    public class Planet : Entity
    {
        public Planet(int id,string name, 
            string rotationPeriod, 
            string orbitalPeriod,
            string diameter, 
            string climate, 
            string gravity, 
            string terrain, 
            string surfaceWater, 
            string population) : base(id)
        {
            Name = name;
            RotationPeriod = rotationPeriod;
            OrbitalPeriod = orbitalPeriod;
            Diameter = diameter;
            Climate = climate;
            Gravity = gravity;
            Terrain = terrain;
            SurfaceWater = surfaceWater;
            Population = population;
        }

        public string Name { get; private set; } = string.Empty;
        public string RotationPeriod { get; private set; } = string.Empty;
        public string OrbitalPeriod { get; private set; } = string.Empty;
        public string Diameter { get; private set; } = string.Empty;
        public string Climate { get; private set; } = string.Empty;
        public string Gravity { get; private set; } = string.Empty;
        public string Terrain { get; private set; } = string.Empty;
        public string SurfaceWater { get; private set; } = string.Empty;
        public string Population { get; private set; } = string.Empty;
        
       // public int CharacterId { get; private set; }
       // public Character Character { get; private set; }
        
        public IEnumerable<Character> Characters { get; private set; }
        
        public IEnumerable<Movie> Movies { get; private set; }
        public IEnumerable<MoviePlanet> MoviePlanets { get; private set; }

        
    }

   
}
