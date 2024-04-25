namespace desafio_shared.Entities
{
    public class Movie : Entity
    {
        public Movie(int id, string title,
            int episode,
            string openingCrawl,
            string director,
            string producer,
            DateTime releaseDate) : base(id)
        {
            Title = title;
            Episode = episode;
            OpeningCrawl = openingCrawl;
            Director = director;
            Producer = producer;
            ReleaseDate = releaseDate;
        }

        public string Title { get; private set; } = string.Empty;
        public int Episode { get; private set; }
        public string OpeningCrawl { get; private set; } = string.Empty;
        public string Director { get; private set; } = string.Empty;
        public string Producer { get; private set; } = string.Empty;
        public DateTime ReleaseDate { get; private set; }

        public ICollection<MovieCharacter> MovieCharacters { get; private set; }
        public IEnumerable<Character> Characters { get; set; } = Enumerable.Empty<Character>();
        public IEnumerable<Planet> Planets { get; set; } = Enumerable.Empty<Planet>();
        public IEnumerable<Vehicle> Vehicles { get; set; } = Enumerable.Empty<Vehicle>();
        public IEnumerable<Starship> Starships { get; set; } = Enumerable.Empty<Starship>();

    }
}
