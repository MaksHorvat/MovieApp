using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private const int DefaultPageSize = 20;
        private const int MaxPageSize = 100;
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("popular")]
        [ProducesResponseType(typeof(PagedResultDto<PopularMovieDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetPopularMovies([FromQuery] int page = 1, [FromQuery] int pageSize = DefaultPageSize)
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = DefaultPageSize;
            if (pageSize > MaxPageSize) pageSize = MaxPageSize;

            var result = await _movieService.GetPopularMoviesAsync(page, pageSize);
            return Ok(result);
        }

        [HttpGet("search")]
        [ProducesResponseType(typeof(PagedResultDto<SearchedMovieDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> SearchMovies(
            [FromQuery(Name = "query")] string searchQuery,
            [FromQuery] string? sortBy,
            [FromQuery] string? filter,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = DefaultPageSize)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return BadRequest("Search query cannot be empty.");
            }
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = DefaultPageSize;
            if (pageSize > MaxPageSize) pageSize = MaxPageSize;

            var result = await _movieService.SearchMoviesAsync(searchQuery, sortBy, filter, page, pageSize);
            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(MovieDetailDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetMovieDetails(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("Invalid Movie ID.");
            }

            var movie = await _movieService.GetMovieByIdAsync(id);

            if (movie == null)
            {
                return NotFound($"Movie with ID {id} not found.");
            }

            return Ok(movie);
        }
    }
}
