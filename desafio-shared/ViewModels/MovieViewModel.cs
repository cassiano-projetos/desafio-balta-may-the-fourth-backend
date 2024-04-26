namespace desafio_backend.ViewModels
{
    public class MovieViewModel 
    {
        public MovieViewModel(string title, int episode, string openingCrawl, string director, string producer, DateTime releaseDate, IEnumerable<BasicInfoViewModel> characters, IEnumerable<BasicInfoViewModel> planets, IEnumerable<BasicInfoViewModel> vehicles, IEnumerable<BasicInfoViewModel> starships)
        {
            Title = title;
            Episode = episode;
            OpeningCrawl = openingCrawl;
            Director = director;
            Producer = producer;
            ReleaseDate = releaseDate;
            Characters = characters;
            Planets = planets;
            Vehicles = vehicles;
            Starships = starships;
        }

        public string Title { get; private set; } = string.Empty;
        public int Episode { get; private set; }
        public string OpeningCrawl { get; private set; } = string.Empty;
        public string Director { get; private set; } = string.Empty;
        public string Producer { get; private set; } = string.Empty;
        public DateTime ReleaseDate { get; private set; }
        public IEnumerable<BasicInfoViewModel> Characters { get; private set; } = Enumerable.Empty<BasicInfoViewModel>();
        public IEnumerable<BasicInfoViewModel> Planets { get; private set; } = Enumerable.Empty<BasicInfoViewModel>();
        public IEnumerable<BasicInfoViewModel> Vehicles { get; private set; } = Enumerable.Empty<BasicInfoViewModel>();
        public IEnumerable<BasicInfoViewModel> Starships { get; private set; } = Enumerable.Empty<BasicInfoViewModel>();
    }
}
