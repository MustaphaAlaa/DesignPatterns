namespace FactoryMethod;

public class SmsNotificationFactory : NotificationFactory
{
    public override INotification GetNotification()
    {
        System.Console.WriteLine("SMS Notification Set;");
        return new SmsNotification();

    }
}
