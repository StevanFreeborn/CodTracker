using MongoDB.Driver;

namespace CodTrackerInfrastructure.Repositories;

public class MatchRepository : IMatchRepository
{
    private readonly IMongoDbContext _context;

    public MatchRepository(IMongoDbContext context)
    {
        _context = context;
    }

    public async Task CreateMatchAsync(Match match)
    {
        await _context.Matches.InsertOneAsync(match);
    }

    public async Task DeleteMatchByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Match> GetMatchByIdAsync(string id)
    {
        var result = await _context.Matches.FindAsync(m => m.Id == id);
        return result.FirstOrDefault();
    }

    public async Task<List<Match>> GetMatchesByUserIdAsync(string userId)
    {
        var result = await _context.Matches.FindAsync(m => m.UserId == userId);
        return result.ToList();
    }

    public async Task UpdateMatchAsync(Match match)
    {
        await _context.Matches.ReplaceOneAsync(m => m.Id == match.Id, match);
    }
}
