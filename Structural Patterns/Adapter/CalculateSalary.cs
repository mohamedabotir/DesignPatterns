using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adapter
{
    public class CalculateSalary
    {
        public double CalcSalary(Employee emp)
        {
            return emp.Salary * 1.5;
        }
    }
}