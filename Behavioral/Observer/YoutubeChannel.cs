namespace Observer;

public class YoutubeChannel : IYoutubeChannel
{

    public string Title { get; private set; }

    public YoutubeChannel(string title)
    {
        Title = title;
        Videos = new();
    }

    public List<string> Videos { get; private set; }
    public List<ISubscriber> Subscribers { get; private set; }
    public void NotifySubscribers(string VideoTitle)
    {
        if (Subscribers is null)
            return;
        foreach (var subscriber in this.Subscribers)
            subscriber.Update(VideoTitle);
    }

    public void Subscribe(ISubscriber subscriber)
    {
        if (this.Subscribers == null)
            this.Subscribers = new();
        this.Subscribers.Add(subscriber);
        System.Console.WriteLine($"{subscriber.Email} Subscribed to {this.Title}");
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        if (this.Subscribers == null)
            return;
        this.Subscribers.Remove(subscriber);
        System.Console.WriteLine($"{subscriber.Email} Unsubscribed");
    }

    public void AddVideo(string VideoTitle)
    {
        this.Videos.Add(VideoTitle);
        NotifySubscribers(VideoTitle);
    }


}