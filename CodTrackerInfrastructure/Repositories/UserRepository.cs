namespace CodTrackerInfrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoDbContext _context;

    public UserRepository(IMongoDbContext context)
    {
        _context = context;
    }

    public void CreateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUserByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Match GetUserByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public void UpdateUserAsync(string id, User user)
    {
        throw new NotImplementedException();
    }
}
