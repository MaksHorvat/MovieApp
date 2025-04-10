using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public class ContainerRegistration : IContainerRegistration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMovieService, MovieService>();
        }
    }
}
