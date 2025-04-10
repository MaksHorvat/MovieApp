using Application.Dtos;
using Application.Interfaces;
using Domain.Interfaces;
using Mapster;

namespace Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private const int MaxPopularMovies = 50;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<MovieDetailDto?> GetMovieByIdAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            if (movie == null)
            {
                return null;
            }

            var movieDto = movie.Adapt<MovieDetailDto>();
            // Handle specific mapping logic if needed (like FullPosterUrl, Genres split) in the profile or here
            // movieDto.FullPosterUrl = $"https://your-image-base-url.com{movie.PosterUrl}"; // If not handled by AutoMapper profile
            // movieDto.Genres = movie.Genres?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries) ?? Enumerable.Empty<string>(); // If not handled
            return movieDto;

        }

        public async Task<PagedResultDto<PopularMovieDto>> GetPopularMoviesAsync(int page, int pageSize)
        {
            // Clamp pageSize if needed, calculate total items needed considering the MaxPopularMovies limit
            // Note: The requirement asks for *Top 50*. This usually means the first 50 overall.
            // If the user asks for page 3 with pageSize 20, they shouldn't get movies ranked 41-60 if only top 50 are "popular".
            // However, the prompt also asks for pagination *on* the popular endpoint. This implies the *source* list might be larger,
            // but we order by popularity and paginate through that ordered list. Let's implement standard pagination on the ordered list.
            // The "Top 50" might be interpreted as the client should ideally only fetch page 1/2/3 depending on page size to get the top 50.

            var totalCount = await _movieRepository.GetPopularMoviesCountAsync(); // Get total count for pagination info
            var movies = _movieRepository.GetPopularMoviesAsync(page, pageSize);
            //TODO: handling errors

            var movieDtos = movies.Adapt<IEnumerable<PopularMovieDto>>();

            return new PagedResultDto<PopularMovieDto>
            {
                Items = movieDtos,
                Page = page,
                PageSize = pageSize,
                TotalCount = totalCount
            };
        }


        public async Task<PagedResultDto<SearchedMovieDto>> SearchMoviesAsync(string query, string? sortBy, string? filter, int page, int pageSize)
        {
            var totalCount = await _movieRepository.GetSearchMoviesCountAsync(query, filter);
            var movies = _movieRepository.SearchMoviesAsync(query, sortBy, filter, page, pageSize);

            var movieDtos = movies.Adapt<IEnumerable<SearchedMovieDto>>();

            return new PagedResultDto<SearchedMovieDto>
            {
                Items = movieDtos,
                Page = page,
                PageSize = pageSize,
                TotalCount = totalCount
            };
        }
    }
}
