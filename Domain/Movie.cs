namespace Domain
{
    public class Movie
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string PosterUrl { get; private set; }
        public string Overview { get; private set; }
        public string Genres { get; private set; } // TODO: Comma-separated genres
        public int Rating { get; private set; }
        public int? Runtime { get; private set; } // Runtime in minutes
        public string Language { get; private set; }

        private Movie() { }

        public Movie(string title, DateTime releaseDate, string posterUrl, string overview, string genres, int rating, int? runtime, string language)
        {
            // TODO: (Guard clauses)
            Title = title;
            ReleaseDate = releaseDate;
            PosterUrl = posterUrl;
            Overview = overview;
            Genres = genres;
            Rating = rating;
            Runtime = runtime;
            Language = language;
        }
    }
}
