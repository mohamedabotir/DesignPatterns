using Decorator;

var MessageService = new MessageServiceConcrete();
var notification = new NotificationConcreteEmailDecorator();
notification.setService(MessageService);
Console.WriteLine(notification.SendMessage("Mohamed", 1005, "Hi Ahmed How Are You"));