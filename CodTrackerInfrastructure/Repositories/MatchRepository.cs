using CodTrackerCore.Interfaces;
using CodTrackerCore.Models;
using CodTrackerInfrastructure.Interfaces;

namespace CodTrackerInfrastructure.Repositories;

public class MatchRepository : IMatchRepository
{
    private readonly IMongoDbContext _context;

    public MatchRepository(IMongoDbContext context)
    {
        _context = context;
    }

    public void CreateMatchAsync(Match match)
    {
        throw new NotImplementedException();
    }

    public void DeleteMatchByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Match GetMatchByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public List<Match> GetMatchesByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public void UpdateMatchAsync(string id, Match match)
    {
        throw new NotImplementedException();
    }
}
