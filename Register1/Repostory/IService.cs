using Register1.Model;

namespace Register1.Repostory
{
    public interface IService
    {
        Task<User> GetByIDAsync(int id);
        Task<bool> SignUpAsync(User user);
        Task<bool> LogInAsync(string email, string password);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<bool> RemoveUserAsync(int id);
    }
}
