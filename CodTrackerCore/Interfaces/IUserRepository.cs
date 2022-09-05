namespace CodTrackerCore.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetUsersAsync();

    Task<User> GetUserByIdAsync(string id);

    Task DeleteUserByIdAsync(string id);

    Task CreateUserAsync(User user);

    Task UpdateUserAsync(string id, User user);
}
