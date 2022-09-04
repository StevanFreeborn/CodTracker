namespace CodTrackerInfrastructure.Configuration;

public class MongoDbOptions
{
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
    public string UsersCollectionName { get; set; }
    public string MatchesCollectionName { get; set; }
}
