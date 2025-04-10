using Application.Interfaces;
using Domain.Interfaces;
using Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public class ContainerRegistration : IContainerRegistration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
        }
    }
}
