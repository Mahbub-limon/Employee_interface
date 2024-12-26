using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_interface
{
    internal class PartTimeEmployee : IEmployee
    {
        public string GetEmployeeDetails (int employeeId)
        {
            return $"Part-time employee details for ID {employeeId}";
        }


        public decimal CalculateSalary(int employeeId) 
        {

            return 2000m;
        
        }


    }
}
