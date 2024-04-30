namespace desafio_backend.ViewModels
{
    public class StarshipViewModel
    {
        public StarshipViewModel(string name, string model, string manufacturer, string costInCredits, string length, string maxSpeed, string crew, string passengers, string cargoCapacity, string hyperdriveRating, string mglt, string consumables, string @class, IEnumerable<BasicMovieInfoViewModel> movies)
        {
            Name = name;
            Model = model;
            Manufacturer = manufacturer;
            CostInCredits = costInCredits;
            Length = length;
            MaxSpeed = maxSpeed;
            Crew = crew;
            Passengers = passengers;
            CargoCapacity = cargoCapacity;
            HyperdriveRating = hyperdriveRating;
            Mglt = mglt;
            Consumables = consumables;
            Class = @class;
        }

        public string Name { get; private set; } = string.Empty;
        public string Model { get; private set; } = string.Empty;
        public string Manufacturer { get; private set; } = string.Empty;
        public string CostInCredits { get; private set; } = string.Empty;
        public string Length { get; private set; } = string.Empty;
        public string MaxSpeed { get; private set; } = string.Empty;
        public string Crew { get; private set; } = string.Empty;
        public string Passengers { get; private set; } = string.Empty;
        public string CargoCapacity { get; private set; } = string.Empty;
        public string HyperdriveRating { get; private set; } = string.Empty;
        public string Mglt { get; private set; } = string.Empty;
        public string Consumables { get; private set; } = string.Empty;
        public string Class { get; private set; } = string.Empty;
        
        public IEnumerable<BasicMovieInfoViewModel> Movies { get; private set; }
    }
}
