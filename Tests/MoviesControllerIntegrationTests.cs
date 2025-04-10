using Api;
using Application.Dtos;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Json;
using Tests.Helpers;

public class MoviesControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public MoviesControllerIntegrationTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.WithWebHostBuilder(builder =>
    {
        builder.ConfigureServices(services =>
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>));
            if (descriptor != null)
                services.Remove(descriptor);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("IntegrationTestDb"));

            var sp = services.BuildServiceProvider();

            using var scope = sp.CreateScope();
            var scopedServices = scope.ServiceProvider;
            var db = scopedServices.GetRequiredService<ApplicationDbContext>();
            db.Database.EnsureCreated();
            TestDataSeeder.Seed(db);
        });
    }).CreateClient();
    }

    [Fact]
    public async Task GetMovieById_ReturnsMovieDetails()
    {
        var movieId = "0d297f3c-b3fd-4425-9f34-a028c463e27c";

        var response = await _client.GetAsync($"/api/movies/{movieId}");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var movie = await response.Content.ReadFromJsonAsync<MovieDetailDto>();
        Assert.NotNull(movie);
        Assert.Equal("Demolition Man", movie.Title);
    }

    [Fact]
    public async Task GetPopularMovies_ReturnsPagedResults()
    {
        var response = await _client.GetAsync("/api/movies/popular?page=1&pageSize=10");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var result = await response.Content.ReadFromJsonAsync<PagedResultDto<PopularMovieDto>>();
        Assert.NotNull(result);
        Assert.Equal(10, result.Items.Count());
        Assert.True(result.TotalCount > 0);
    }

    [Fact]
    public async Task SearchMovies_ReturnsFilteredResults()
    {
        var response = await _client.GetAsync("/api/movies/search?query=Popular&page=1&pageSize=10");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var result = await response.Content.ReadFromJsonAsync<PagedResultDto<SearchedMovieDto>>();
        Assert.NotNull(result);
        Assert.Equal(10,result.Items.Count());
    }
}
