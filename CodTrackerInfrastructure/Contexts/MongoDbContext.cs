using CodTrackerCore.Models;
using CodTrackerInfrastructure.Configuration;
using CodTrackerInfrastructure.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CodTrackerInfrastructure.Contexts;

public class MongoDbContext : IMongoDbContext
{
    public IMongoCollection<User> Users { get; set; }
    public IMongoCollection<Match> Matches { get; set; }

    public MongoDbContext(IOptions<MongoDbOptions> options)
    {
        var client = new MongoClient(options.Value.ConnectionString);
        var database = client.GetDatabase(options.Value.DatabaseName);
        Users = database.GetCollection<User>(options.Value.UsersCollectionName);
        Matches = database.GetCollection<Match>(options.Value.MatchesCollectionName);
    }
}
