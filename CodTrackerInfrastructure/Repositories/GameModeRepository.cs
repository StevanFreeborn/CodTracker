namespace CodTrackerInfrastructure.Repositories;

public class GameModeRepository : IGameModeRepository
{
    private readonly IMongoDbContext _context;
    public GameModeRepository(IMongoDbContext context)
    {
        _context = context;
    }

    public async Task<List<GameMode>> GetGameModesAsync()
    {
        var result = await _context.GameModes.FindAsync(_ => true);
        return result.ToList();
    }

    public async Task CreateGameModeAsync(GameMode gameMode)
    {
        await _context.GameModes.InsertOneAsync(gameMode);
    }
}
