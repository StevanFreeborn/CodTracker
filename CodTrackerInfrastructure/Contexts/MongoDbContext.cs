using CodTrackerInfrastructure.Configuration;
using Microsoft.Extensions.Options;

namespace CodTrackerInfrastructure.Contexts;

public class MongoDbContext : IMongoDbContext
{
    public IMongoCollection<User> Users { get; set; }
    public IMongoCollection<Match> Matches { get; set; }
    public IMongoCollection<GameMode> GameModes { get; set; }

    public MongoDbContext(IOptions<MongoDbOptions> options)
    {
        var client = new MongoClient(options.Value.ConnectionString);
        var database = client.GetDatabase(options.Value.DatabaseName);
        Users = database.GetCollection<User>(options.Value.UsersCollectionName);
        Matches = database.GetCollection<Match>(options.Value.MatchesCollectionName);
        GameModes = database.GetCollection<GameMode>(options.Value.GameModesCollectionName);
    }
}
