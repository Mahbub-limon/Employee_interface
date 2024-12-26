using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_interface
{
    internal interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);

        decimal CalculateSalary(int employeeId);
    }
}
