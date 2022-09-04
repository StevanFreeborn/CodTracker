namespace CodTrackerCore.Interfaces;

public interface IUserRepository
{
    List<User> GetUsersAsync();

    Match GetUserByIdAsync(string id);

    void DeleteUserByIdAsync(string id);

    void CreateUserAsync(User user);

    void UpdateUserAsync(string id, User user);
}
