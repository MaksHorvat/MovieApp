using Domain;
using Domain.Interfaces;

namespace Infrastructure.Persistance
{
    public class MovieRepository : IMovieRepository
    {
        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movie> GetPopularMoviesAsync(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetPopularMoviesCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetSearchMoviesCountAsync(string query, string? filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movie> SearchMoviesAsync(string query, string? sortBy, string? filter, int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
