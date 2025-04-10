using Domain;
using Infrastructure.Persistence;

namespace Tests.Helpers
{
    internal class TestDataSeeder
    {
        public static void Seed(ApplicationDbContext dbContext)
        {
            if (dbContext.Movies.Any())
                return;

            var movies = new List<Movie>();

            movies.Add(new Movie(
                title: "The Dark Knight",
                releaseDate: new DateTime(2008, 7, 18),
                posterUrl: "/posters/darkknight.jpg",
                overview: "When the menace known as the Joker emerges...",
                genres: "Action,Drama,Thriller",
                rating: 9,
                runtime: 152,
                language: "English"
            ));

            for (int i = 1; i <= 60; i++)
            {
                movies.Add(new Movie(
                    title: $"Popular Movie Title {i}",
                    releaseDate: new DateTime(2015 + (i % 10), (i % 12) + 1, (i % 28) + 1),
                    posterUrl: $"/posters/popular{i}.jpg",
                    overview: $"Overview for popular movie {i}.",
                    genres: i % 3 == 0 ? "Action,Adventure" : i % 3 == 1 ? "Comedy,Romance" : "Drama,Thriller",
                    rating: i % 11,
                    runtime: 120 + (i % 30),
                    language: i % 2 == 0 ? "English" : "Spanish"
                ));
            }

            dbContext.Movies.AddRange(movies);
            dbContext.SaveChanges();
        }
    }
}
