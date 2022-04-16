// See https://aka.ms/new-console-template for more information
using prototype;
EmployeePrototype copy1 = new RegularEmployee();
copy1.Id = 15;
copy1.Name = "mohamed";
copy1.EmpAddress = new Address{st="kz",zipcode=30215};

Console.WriteLine(copy1);

EmployeePrototype copy2 = copy1.ShallowCopy();
copy2.EmpAddress.st="tanta";
Console.WriteLine(copy2);
Console.WriteLine(copy1);


/*========================Deep*/


EmployeePrototype copy3 = new RegularEmployee();
copy3.Id = 15;
copy3.Name = "mohamed";
copy3.EmpAddress = new Address{st="kz",zipcode=30215};

Console.WriteLine(copy3);

EmployeePrototype copy4 = copy3.DeepCopy();
copy4.EmpAddress.st="tanta";
Console.WriteLine(copy3);
Console.WriteLine(copy4);
