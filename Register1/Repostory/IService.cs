using Register1.Model;

namespace Register1.Repostory
{
    public interface IService
    {
        Task<bool> SignUpAsync(User user);
        Task<bool> LogIn(string email, string password);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
