using LinqToDB;
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
        public async Task<bool> LogIn(string email, string password)
        {
            var res = await _registr.Users.FirstOrDefaultAsync(p => p.Email == email && p.Password == password);
            if (res == null)
            {
                return false;
            }

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
