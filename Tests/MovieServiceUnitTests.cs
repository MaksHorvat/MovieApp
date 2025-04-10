using Application;
using Domain;
using Domain.Interfaces;
using NSubstitute;

public class MovieServiceTests
{
    private readonly IMovieRepository _movieRepositoryMock;
    private readonly MovieService _movieService;

    public MovieServiceTests()
    {
        _movieRepositoryMock = Substitute.For<IMovieRepository>();
        _movieService = new MovieService(_movieRepositoryMock);
    }

    [Fact]
    public async Task GetMovieByIdAsync_ReturnsMovieDetailDto_WhenMovieExists()
    {
        var movieId = Guid.NewGuid();
        var movie = new Movie(
            "Inception",
            new DateTime(2010, 7, 16),
            "https://example.com/inception.jpg",
            "A mind-bending thriller",
            "Sci-Fi, Thriller",
            9,
            148,
            "English");

        _movieRepositoryMock.GetByIdAsync(movieId).Returns(movie);

        var result = await _movieService.GetMovieByIdAsync(movieId);

        Assert.NotNull(result);
        Assert.Equal(movie.Title, result.Title);
        Assert.Equal(movie.ReleaseDate, result.ReleaseDate);
    }

    [Fact]
    public async Task GetMovieByIdAsync_ReturnsNull_WhenMovieDoesNotExist()
    {
        var movieId = Guid.NewGuid();

        _movieRepositoryMock.GetByIdAsync(movieId).Returns((Movie?)null);

        var result = await _movieService.GetMovieByIdAsync(movieId);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetPopularMoviesAsync_ReturnsPagedResultDto()
    {
        var movies = Enumerable.Range(1, 10).Select(i => new Movie(
            $"Popular Movie {i}",
            DateTime.Now.AddYears(-i),
            $"https://example.com/movie{i}.jpg",
            $"Overview for movie {i}",
            "Action, Adventure",
            8,
            120,
            "English"
        )).AsQueryable();

        _movieRepositoryMock.GetPopularMoviesCountAsync().Returns(50);
        _movieRepositoryMock.GetPopularMovies(1, 10).Returns(movies);

        var result = await _movieService.GetPopularMoviesAsync(1, 10);

        Assert.NotNull(result);
        Assert.Equal(10, result.Items.Count());
        Assert.Equal(50, result.TotalCount);
    }

    [Fact]
    public async Task SearchMoviesAsync_ReturnsFilteredResults()
    {
        var query = "Inception";
        var movies = new List<Movie>
        {
            new Movie(
                "Inception",
                new DateTime(2010, 7, 16),
                "https://example.com/inception.jpg",
                "A mind-bending thriller",
                "Sci-Fi, Thriller",
                9,
                148,
                "English"
            )
        }.AsQueryable();

        _movieRepositoryMock.GetSearchMoviesCountAsync(query, null).Returns(1);
        _movieRepositoryMock.SearchMovies(query, null, null, 1, 10).Returns(movies);

        var result = await _movieService.SearchMoviesAsync(query, null, null, 1, 10);

        Assert.NotNull(result);
        Assert.Single(result.Items);
        Assert.Equal("Inception", result.Items.First().Title);
    }
}
