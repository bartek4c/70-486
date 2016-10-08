using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotManager.Core.Workflow
{
    public class Car
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int YearBuild { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}