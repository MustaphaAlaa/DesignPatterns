namespace Observer;

public class User : ISubscriber
{
    public string Email { get; set; }

    public void Update(string VideoTitle)
    {
        System.Console.WriteLine($"{this.Email} Received a notification for {VideoTitle} Video is added");
    }
}
