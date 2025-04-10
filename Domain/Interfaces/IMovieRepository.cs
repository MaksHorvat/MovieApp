namespace Domain.Interfaces
{
    public interface IMovieRepository
    {
        Task<Movie?> GetByIdAsync(Guid id);
        IQueryable<Movie> GetPopularMovies(int page, int pageSize);
        Task<int> GetPopularMoviesCountAsync();
        Task<int> GetSearchMoviesCountAsync(string query, string? filter);
        IQueryable<Movie> SearchMovies(string query, string? sortBy, string? filter, int page, int pageSize);
    }
}
