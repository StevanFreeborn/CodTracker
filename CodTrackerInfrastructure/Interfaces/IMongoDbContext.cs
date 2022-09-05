namespace CodTrackerInfrastructure.Interfaces;

public interface IMongoDbContext
{
    IMongoCollection<Match> Matches { get; set; }
    IMongoCollection<User> Users { get; set; }
    IMongoCollection<GameMode> GameModes { get; set; }
}