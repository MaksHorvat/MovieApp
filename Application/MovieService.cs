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

        public async Task<MovieDetailDto?> GetMovieByIdAsync(Guid id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            if (movie == null)
            {
                return null;
            }

            var movieDto = movie.Adapt<MovieDetailDto>();
            return movieDto;

        }

        public async Task<PagedResultDto<PopularMovieDto>> GetPopularMoviesAsync(int page, int pageSize)
        {
            var totalCount = await _movieRepository.GetPopularMoviesCountAsync();
            var movies = _movieRepository.GetPopularMovies(page, pageSize).ToList();
            //TODO: handling errors

            var movieDtos = movies.Select(movie => movie.Adapt<PopularMovieDto>()).ToList();

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
            var movies = _movieRepository.SearchMovies(query, sortBy, filter, page, pageSize);

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
