using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Core.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int Age { get; set; }
        public decimal? Salary { get; set; }
        public string? Position { get; set; }
    }
}
