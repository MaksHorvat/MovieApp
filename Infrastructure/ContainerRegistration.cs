using Application.Interfaces;
using Domain.Interfaces;
using Infrastructure.Database;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public class ContainerRegistration : IContainerRegistration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MoviesDB");

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddScoped<IMovieRepository, MovieRepository>();
        }
    }
}
