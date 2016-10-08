using MotManager.Core.Workflow;
using MotManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotManager.Services
{
    public class CarService
    {
        public IEnumerable<Car> GetAllCars()
        {
            var _carRepo = new CarRepository();

            return _carRepo.GetAllCars();
        }
    }
}
