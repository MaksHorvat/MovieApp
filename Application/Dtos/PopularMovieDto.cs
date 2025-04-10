namespace Application.Dtos
{
    public class PopularMovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }
        public decimal Rating { get; set; }
    }
}
