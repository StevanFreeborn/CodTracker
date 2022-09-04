namespace CodTrackerCore.Interfaces;

public interface IMatchRepository
{
    List<Match> GetMatchesByUserIdAsync(string userId);

    Match GetMatchByIdAsync(string id);

    void DeleteMatchByIdAsync(string id);

    void CreateMatchAsync(Match match);

    void UpdateMatchAsync(string id, Match match);
}
