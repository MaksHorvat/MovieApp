using Application.Dtos;

namespace Application.Interfaces
{
    public interface IMovieService
    {
        Task<MovieDetailDto?> GetMovieByIdAsync(int id);
        Task<PagedResultDto<PopularMovieDto>> GetPopularMoviesAsync(int page, int pageSize);
        Task<PagedResultDto<SearchedMovieDto>> SearchMoviesAsync(string query, string? sortBy, string? filter, int page, int pageSize);
    }
}
