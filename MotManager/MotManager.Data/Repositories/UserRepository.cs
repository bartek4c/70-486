using MotManager.Core.Entities.Account;
using MotManager.Core.Repositories;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MotManager.Data.Repositories
{
    internal class UserRepository : Repository<User>, IUserRepository
    {
        internal UserRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public User FindByUserName(string username)
        {
            return Set.FirstOrDefault(x => x.UserName == username);
        }

        public Task<User> FindByUserNameAsync(string username)
        {
            return Set.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public Task<User> FindByUserNameAsync(System.Threading.CancellationToken cancellationToken, string username)
        {
            return Set.FirstOrDefaultAsync(x => x.UserName == username, cancellationToken);
        }

        public User FindByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> FindByEmailAsync(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> FindByEmailAsync(System.Threading.CancellationToken cancellationToken, string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
