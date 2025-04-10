using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var basePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\Api"));

        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.Development.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        var connectionString = config.GetConnectionString("MoviesDB");

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        builder.UseSqlServer(connectionString);

        return new ApplicationDbContext(builder.Options);
    }
}
