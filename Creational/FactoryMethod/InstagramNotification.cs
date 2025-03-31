namespace FactoryMethod;

public class InstagramNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Instagram Notification: {message}");
    }
}
