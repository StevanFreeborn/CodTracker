namespace CodTrackerInfrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoDbContext _context;

    public UserRepository(IMongoDbContext context)
    {
        _context = context;
    }

    public async Task CreateUserAsync(User user)
    {
        await _context.Users.InsertOneAsync(user);
    }

    public async Task DeleteUserByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateUserAsync(string id, User user)
    {
        throw new NotImplementedException();
    }
}
