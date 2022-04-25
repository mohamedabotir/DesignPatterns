// See https://aka.ms/new-console-template for more information
using bank;
Console.WriteLine("Hello, World!");

IFactoryBank factory = new FactoryBank();

var readCardNumber = Console.ReadLine();
var code = readCardNumber.Substring(0, 6);
var bankType = factory.GetBankObject(code);
Console.WriteLine("Card Belong To:" + bankType.withdraw());