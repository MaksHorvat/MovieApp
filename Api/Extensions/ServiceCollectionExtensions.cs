using Application.Interfaces;
using System.Reflection;

namespace Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var typesInFolder = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "*.dll", SearchOption.TopDirectoryOnly)
                .Where(x => !x.Contains("SQL", StringComparison.OrdinalIgnoreCase))
                .Select(Assembly.LoadFrom)
                .SelectMany(x => x.ExportedTypes);

            var containerRegistrationTypes = typesInFolder
                .Where(x => x.IsClass && x.GetInterfaces().Any(y => y.Name.Contains("IContainerRegistration")))
                .ToList();

            foreach (var containerRegistration in containerRegistrationTypes)
            {
                var infrastructure = Activator.CreateInstance(containerRegistration) as IContainerRegistration;
                infrastructure?.Register(services, configuration);
            }
        }
    }
}
