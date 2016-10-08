using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using MotManager.Core.Entities.Account;
using MotManager.Data;
using MotManager.Services.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotManager.Services
{
    public class AccountService
    {
        //public ApplicationUserManager GetApplicationUserManager(IOwinContext context)
        //{
        //    var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context.Get<ApplicationDbContext>()));
        //    return manager;
        //}

        //public ApplicationDbContext GetApplicationDbContext()
        //{
        //    var context = new ApplicationDbContext();
        //    return context;
        //}
    }
}
