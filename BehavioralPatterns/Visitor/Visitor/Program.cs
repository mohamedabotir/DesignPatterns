// See https://aka.ms/new-console-template for more information
using Visitor;

 IVisitor visitor = new PrintVisitor();

var house = new HouseReport();
Console.WriteLine(house.CallPrint(visitor));