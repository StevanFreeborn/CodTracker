using CodTrackerInfrastructure.Configuration;
using CodTrackerInfrastructure.Contexts;
using CodTrackerInfrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodTrackerInfrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbOptions>(configuration.GetSection("MongoDbOptions"));
        services.AddScoped<IMongoDbContext, MongoDbContext>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IMatchRepository, MatchRepository>();

        return services;
    }
}
