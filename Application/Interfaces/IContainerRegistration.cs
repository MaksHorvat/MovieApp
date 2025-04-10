using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Interfaces
{
    public interface IContainerRegistration
    {
        void Register(IServiceCollection services, IConfiguration configuration);
    }
}
