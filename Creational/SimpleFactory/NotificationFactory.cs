namespace SimpleFactory;

public static class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            "push" => new PushNotification(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
