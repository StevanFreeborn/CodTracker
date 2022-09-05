namespace CodTrackerCore.Interfaces;
public interface IGameModeRepository
{
    Task<List<GameMode>> GetGameModesAsync();
    Task CreateGameModeAsync(GameMode gameMode);
}
