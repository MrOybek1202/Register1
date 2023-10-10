using Microsoft.EntityFrameworkCore;
using Register1.Model;

namespace Register1.DataLayer
{
    public class RegestorDbContext : DbContext
    {
        public RegestorDbContext(DbContextOptions<RegestorDbContext> option)
            : base(option)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
