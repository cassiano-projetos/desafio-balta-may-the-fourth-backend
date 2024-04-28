namespace desafio_backend.ViewModels
{
    public class PlanetViewModel
    {
        public PlanetViewModel(string name, string rotationPeriod, string orbitalPeriod, string diameter, string climate, string gravity, string terrain, string surfaceWater, string population,IEnumerable<BasicInfoViewModel> characters, IEnumerable<BasicMovieInfoViewModel> movies)
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
            Movies = movies;
            Characters = characters;
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
        
        public IEnumerable<BasicMovieInfoViewModel> Movies { get; private set; } = Enumerable.Empty<BasicMovieInfoViewModel>();
        
        public IEnumerable<BasicInfoViewModel> Characters { get; private set; } = Enumerable.Empty<BasicInfoViewModel>();
    }
}
