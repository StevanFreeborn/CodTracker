using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodTrackerInfrastructure.Repositories;
public class GameModeRepository : IGameModeRepository
{
    private readonly IMongoDbContext _context;
    public GameModeRepository(IMongoDbContext context)
    {
        _context = context;
    }

    public List<GameMode> GetGameModesAsync()
    {
        throw new NotImplementedException();
    }
}
