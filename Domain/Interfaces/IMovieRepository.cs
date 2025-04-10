namespace Domain.Interfaces
{
    public interface IMovieRepository
    {
        Task<Movie> GetByIdAsync(int id);
        IQueryable<Movie> GetPopularMoviesAsync(int page, int pageSize);
        Task<int> GetPopularMoviesCountAsync();
        Task<int> GetSearchMoviesCountAsync(string query, string? filter);
        IQueryable<Movie> SearchMoviesAsync(string query, string? sortBy, string? filter, int page, int pageSize);
    }
}
