using Application;
using Domain;
using Infrastructure.Database;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Tests.Helpers;

public class MovieServiceIntegrationTests
{
    private readonly ApplicationDbContext _dbContext;
    private readonly MovieService _movieService;

    public MovieServiceIntegrationTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new ApplicationDbContext(options);

        TestDataSeeder.Seed(_dbContext);

        var movieRepository = new MovieRepository(_dbContext);
        _movieService = new MovieService(movieRepository);
    }

    [Fact]
    public async Task GetMovieByIdAsync_ReturnsCorrectMovie()
    {
        var movie = _dbContext.Movies.First();

        var result = await _movieService.GetMovieByIdAsync(movie.Id);

        Assert.NotNull(result);
        Assert.Equal(movie.Title, result.Title);
        Assert.Equal(movie.ReleaseDate, result.ReleaseDate);
    }

    [Fact]
    public async Task GetPopularMoviesAsync_ReturnsPagedResults()
    {
        var result = await _movieService.GetPopularMoviesAsync(1, 10);

        Assert.NotNull(result);
        Assert.Equal(61, result.TotalCount);
        Assert.Equal(10, result.Items.Count());
    }

    [Fact]
    public async Task SearchMoviesAsync_ReturnsFilteredResults()
    {
        var result = await _movieService.SearchMoviesAsync("Dark", null, null, 1, 10);

        Assert.NotNull(result);
        Assert.Single(result.Items);
        Assert.Equal("The Dark Knight", result.Items.First().Title);
    }

    //private void SeedDatabase()
    //{
    //    var movies = new List<Movie>();

    //    movies.Add(new Movie(
    //        title: "The Dark Knight",
    //        releaseDate: new DateTime(2008, 7, 18),
    //        posterUrl: "/posters/darkknight.jpg",
    //        overview: "When the menace known as the Joker emerges, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
    //        genres: "Action,Drama,Thriller",
    //        rating: 9,
    //        runtime: 152,
    //        language: "English"
    //    ));

    //    for (int i = 1; i <= 60; i++)
    //    {
    //        movies.Add(new Movie(
    //            title: $"Popular Movie Title {i}",
    //            releaseDate: new DateTime(2015 + (i % 10), (i % 12) + 1, (i % 28) + 1),
    //            posterUrl: $"/posters/popular{i}.jpg",
    //            overview: $"Overview for popular movie {i}. It's quite an interesting film about many things.",
    //            genres: i % 3 == 0 ? "Action,Adventure" : (i % 3 == 1 ? "Comedy,Romance" : "Drama,Thriller"),
    //            rating: i % 11,
    //            runtime: 120 + (i % 30),
    //            language: i % 2 == 0 ? "English" : "Spanish"
    //        ));
    //    }

    //    _dbContext.Movies.AddRange(movies);
    //    _dbContext.SaveChanges();
    //}
}