using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototype
{
    public abstract class EmployeePrototype
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
    
        public Address EmpAddress{set;get;}
        public abstract EmployeePrototype ShallowCopy();
        public abstract EmployeePrototype DeepCopy();
        public override string ToString()
        {
            return $@"EmployeeId:{this.Id}
              EmployeeName:{this.Name}
              EmployeeAddress:{this.EmpAddress.st}  {this.EmpAddress.zipcode}          
            ";
        }
    }
}