namespace Observer;

public interface ISubscriber
{
    string Email { get; set; }
    void Update(string VideoTitle);
}
