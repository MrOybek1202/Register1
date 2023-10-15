using LinqToDB;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Register1.DataLayer;
using Register1.Model;

namespace Register1.Repostory
{
    public class Servace : IService
    {
        private readonly RegestorDbContext _registr;

        public Servace(RegestorDbContext registr)
        {
            _registr = registr;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var result = await _registr.Users.ToListAsync();

            if(result == null)
            {
                return result;

            }
            return result;
        }

        public async Task<User> GetByIDAsync(int id)
        {
            var res = await _registr.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(res == null)
            {
                return res;

            }
            return res;
        }

        

        public async Task<bool> LogInAsync(string email, string password)
        {
            var res = await _registr.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
            if (res == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> RemoveUserAsync(int id)
        {
            var res = await _registr.Users.FirstOrDefaultAsync(p => p.Id == id);
            if(res == null)
            {
                return false;

            }
            _registr.Users.Remove(res);
            _registr.SaveChanges();
            return true;
        }

        public async Task<bool> SignUpAsync(User user)
        {
            if (user != null)
            {
                await _registr.AddAsync(user);
                _registr.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
