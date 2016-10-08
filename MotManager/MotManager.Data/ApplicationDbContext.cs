using Microsoft.AspNet.Identity.EntityFramework;
using MotManager.Core.Entities.Account;
using MotManager.Core.Workflow;
using MotManager.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotManager.Data
{
    internal class ApplicationDbContext : DbContext
    {
        internal ApplicationDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        internal IDbSet<User> Users { get; set; }
        internal IDbSet<Role> Roles { get; set; }
        internal IDbSet<ExternalLogin> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new ExternalLoginConfiguration());
            modelBuilder.Configurations.Add(new ClaimConfiguration());
        }
    }

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //{
    //    public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
    //    {
    //    }

    //    public static ApplicationDbContext Create()
    //    {
    //        return new ApplicationDbContext();
    //    }

    //    public DbSet<Car> Cars { get; set; }
    //}
}
