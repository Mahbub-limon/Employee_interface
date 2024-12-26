
using Employee_interface;

FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();

Console.WriteLine(fullTimeEmployee.GetEmployeeDetails(1));
Console.WriteLine($"Salary : {fullTimeEmployee.CalculateSalary(1)}");


PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
Console.WriteLine(partTimeEmployee.GetEmployeeDetails(2));
Console.WriteLine($"Salary : {partTimeEmployee.CalculateSalary(2)}");
