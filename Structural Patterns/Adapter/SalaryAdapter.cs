using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adapter;
using external;
namespace Adapter
{
    public class SalaryAdapter : CalculateSalary
    {
        public Employee Emp;

        public double CalcSalary(ExternalApi emp)
        {
            Emp = new Employee();
            Emp.Salary = emp.Salary;
            return base.CalcSalary(Emp);
        }
    }
}