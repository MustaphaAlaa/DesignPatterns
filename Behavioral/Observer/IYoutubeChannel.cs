namespace Observer;

public interface IYoutubeChannel
{
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void NotifySubscribers(string VideoTitle);
}
