namespace Application.Dtos
{
    public class MovieDetailDto
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string FullPosterUrl { get; set; }
        public string Overview { get; set; } 
        public string Genres { get; set; }
        public decimal AverageRating { get; set; }
        public int? Runtime { get; set; }
        public string Language { get; set; }
    }
}
