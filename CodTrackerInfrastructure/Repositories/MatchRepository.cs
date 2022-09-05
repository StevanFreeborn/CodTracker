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
        throw new NotImplementedException();
    }

    public async Task<List<Match>> GetMatchesByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateMatchAsync(string id, Match match)
    {
        throw new NotImplementedException();
    }
}
