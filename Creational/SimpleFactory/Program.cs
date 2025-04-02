using SimpleFactory;

INotification notification = NotificationFactory.CreateNotification("email");
notification.Send("Your ticket has been updated!");

notification = NotificationFactory.CreateNotification("sms");
notification.Send("Your ticket has been closed.");