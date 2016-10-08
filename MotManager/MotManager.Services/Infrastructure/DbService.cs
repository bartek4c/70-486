using MotManager.Data.DbInitializers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotManager.Services.Infrastructure
{
    public class DbService
    {
        public void InitializeDatabase()
        {
            Database.SetInitializer(new MotManagerDbInitializer());
        }
    }
}
