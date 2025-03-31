namespace FactoryMethod;

public class InstagramNotificationFactory : NotificationFactory
{
    public override INotification GetNotification()
    {
        System.Console.WriteLine("Instagram Notification Set;");
        return new InstagramNotification();

    }
}