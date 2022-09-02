using external;
using adapter;
using Adapter;

var employee = new Employee();
employee.Salary = 5500;
var external = new ExternalApi();
external.Salary = 1200;

var calc = new SalaryAdapter();

Console.WriteLine(calc.CalcSalary(external));
