using Proxy;
var sms = new MessageProxy();

Console.WriteLine(sms.SendMessage("mohamed", 15, "hello ahmed!"));
Console.WriteLine(sms.SendMessage("mohamed", 15, "hello ali!"));
Console.WriteLine(sms.SendMessage("mohamed", 15, "hello adel!"));
Console.WriteLine(sms.SendMessage("mohamed", 15, "hello noha!"));