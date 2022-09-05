namespace CodTrackerCore.Interfaces;

public interface IMatchRepository
{
    Task<List<Match>> GetMatchesByUserIdAsync(string userId);

    Task<Match> GetMatchByIdAsync(string id);

    Task DeleteMatchByIdAsync(string id);

    Task CreateMatchAsync(Match match);

    Task UpdateMatchAsync(string id, Match match);
}
