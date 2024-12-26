using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_interface
{
    internal class FullTimeEmployee  : IEmployee
    {
        public string GetEmployeeDetails (int  employeeId)
        {
            return $"Full time Employee details for ID{ employeeId}";
        }

        public decimal CalculateSalary(int employeeId) 
        {

            return 4000m;
        }

    }
}
