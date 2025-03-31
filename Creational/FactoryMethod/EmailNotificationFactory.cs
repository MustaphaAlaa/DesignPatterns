namespace FactoryMethod;

public class EmailNotificationFactory : NotificationFactory
{
    public override INotification GetNotification()
    {
        System.Console.WriteLine("Email Notification Set;");

        return new EmailNotification();
    }
}
