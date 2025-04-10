using Domain;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Database
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public IQueryable<Movie> GetPopularMoviesAsync(int page, int pageSize)
        {
            return _context.Movies
                .OrderByDescending(m => m.Rating)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking();
        }

        public async Task<int> GetPopularMoviesCountAsync()
        {
            return await _context.Movies.CountAsync();
        }

        public async Task<int> GetSearchMoviesCountAsync(string query, string? filter)
        {
            var queryable = _context.Movies.AsQueryable();

            queryable = queryable.Where(m => m.Title.Contains(query));
            
            if (!string.IsNullOrWhiteSpace(filter))
                 queryable = queryable.Where(m => m.Genres.Contains(filter));

            return await queryable.CountAsync();
        }

        public IQueryable<Movie> SearchMoviesAsync(string query, string? sortBy, string? filter, int page, int pageSize)
        {
            var queryable = _context.Movies.AsQueryable();

            queryable = queryable.Where(m => m.Title.Contains(query));

            if (!string.IsNullOrWhiteSpace(filter))
                 queryable = queryable.Where(m => m.Genres.Contains(filter));

            Expression<Func<Movie, object>> keySelector = sortBy?.ToLower() switch
            {
                "title" => m => m.Title,
                "release_date" => m => m.ReleaseDate,
                "rating" => m => m.Rating,
                _ => m => m.Rating
            };

            bool descending = sortBy?.ToLower() == "rating" || string.IsNullOrEmpty(sortBy);
            if(descending)
                 queryable = queryable.OrderByDescending(keySelector);
            else
                 queryable = queryable.OrderBy(keySelector);

            return queryable
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking();;
        }
    }
}
