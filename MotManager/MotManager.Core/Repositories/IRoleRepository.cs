using MotManager.Core.Entities.Account;
using System.Threading;
using System.Threading.Tasks;

namespace MotManager.Core.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role FindByName(string roleName);
        Task<Role> FindByNameAsync(string roleName);
        Task<Role> FindByNameAsync(CancellationToken cancellationToken, string roleName);
    }
}
