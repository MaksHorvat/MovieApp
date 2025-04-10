using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public static class MovieSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var movies = new List<object>();

            for (int i = 1; i <= 60; i++)
            {
                movies.Add(new
                {
                    Id = GetPopularMovieId(i),
                    Title = $"Popular Movie Title {i}",
                    ReleaseDate = new DateTime(2015 + (i % 10), (i % 12) + 1, (i % 28) + 1),
                    PosterUrl = $"/posters/popular{i}.jpg",
                    Overview = $"Overview for popular movie {i}. It's quite an interesting film about many things.",
                    Genres = i % 3 == 0 ? "Action,Adventure" : (i % 3 == 1 ? "Comedy,Romance" : "Drama,Thriller"),
                    Rating = i % 11,
                    Runtime = 120 + (i % 30),
                    Language = i % 2 == 0 ? "English" : "Spanish"
                });
            }

            movies.Add(new {Id=Guid.Parse("0d297f3c-b3fd-4425-9f34-a028c463e27c"), Title="Demolition Man", ReleaseDate= new DateTime(1993, 5, 1),PosterUrl="/posters/DemolitionMan.jpg", Overview="A police officer is brought out of suspended animation in prison to pursue.", Genres="Adventure,Action,Thriller", Rating=6, Runtime=115, Language="English" });
            movies.Add(new {Id=Guid.Parse("21564b30-2e22-4b32-b139-d831218ae401"), Title="Transformers: The Last Knight", ReleaseDate= new DateTime(2017, 5, 1),PosterUrl="/posters/TransformersTheLastKnight.jpg", Overview=" deadly threat from Earth's history reappears and a hunt for a lost artifact takes place.", Genres="Adventure,Action,Thriller", Rating=5, Runtime=155, Language="English" });
            movies.Add(new {Id=Guid.Parse("de9f6727-6d75-49ae-a6df-7e4d827dfc25"), Title="Free Guy", ReleaseDate= new DateTime(2021, 5, 1),PosterUrl="/posters/FreeGuy.jpg", Overview="When Guy, a bank teller, learns that he is a non-player character in a bloodthirsty,.", Genres="Adventure,Action,Comedy", Rating=7, Runtime=115, Language="English" });

            modelBuilder.Entity<Movie>().HasData(movies);
        }

        public static Guid GetPopularMovieId(int index)
        {
            return Guid.ParseExact($"00000000-0000-0000-0000-{index.ToString("D12")}", "D");
        }
    }
}
