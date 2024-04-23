namespace desafio_shared.Entities
{
    public class Movie
    {
        public Movie(string title, 
            int episode, 
            string openingCrawl, 
            string director, 
            string producer, 
            DateTime releaseDate)
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
    }
}
