using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using MotManager.Core;
using MotManager.Core.Workflow;
using MotManager.Core.Entities.Account;

namespace MotManager.Data.DbInitializers
{
    //public class MotManagerDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    //{
    //    public override void InitializeDatabase(ApplicationDbContext context)
    //    {
    //        //a way to drop existing connections which might prevent database from being dropped
    //        var sqlCommand = string.Format("alter database [{0}] set single_user with rollback immediate", context.Database.Connection.Database);
    //        context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCommand);

    //        base.InitializeDatabase(context);
    //    }

    //    protected override void Seed(ApplicationDbContext context)
    //    {
    //        context.Cars.Add(new Car
    //        {
    //            Make = "Volvo",
    //            Model = "S40",
    //            RegistrationDate = new DateTime(2011, 3, 12),
    //            RegistrationNumber = "SE11 JXT",
    //            YearBuild = 2011
    //        });

    //        context.Users.Add(new ApplicationUser
    //        {
    //            Email = "bartek4c@wp.pl",
    //            EmailConfirmed = false,
    //            PasswordHash = "AGZeZUnGuaMYv4pjpn4tfkGKPZwvtKiEL51K0sqWDb5Iy3YyE8r5hkv5XiL6a1CZXA==",
    //            SecurityStamp = "c8efab61-f2ae-444c-be65-a647808d9537",
    //            PhoneNumberConfirmed = false,
    //            TwoFactorEnabled = false,
    //            LockoutEnabled = true,
    //            AccessFailedCount = 0,
    //            UserName = "bartek4c@wp.pl"
    //        });

    //        base.Seed(context);
    //    }
    //}
}