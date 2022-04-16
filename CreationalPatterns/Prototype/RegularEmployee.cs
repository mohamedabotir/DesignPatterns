using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototype
{
    public class RegularEmployee :EmployeePrototype
    {
        public override EmployeePrototype ShallowCopy(){
        return (RegularEmployee) this.MemberwiseClone();
        }
        public override EmployeePrototype DeepCopy(){
            RegularEmployee emp = new RegularEmployee();
            emp = (RegularEmployee) this.MemberwiseClone();
            emp.EmpAddress = new Address{st=EmpAddress.st,zipcode=EmpAddress.zipcode};
            emp.Name = this.Name;

         return emp;
        }
    }
}