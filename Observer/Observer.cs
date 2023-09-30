// Subject (Observable)
public interface INewsPublisher
{
    void AddSubscriber(INewsSubscriber subscriber);
    void RemoveSubscriber(INewsSubscriber subscriber);
    void NotifySubscribers(string news);
}

// Concrete Subject
public class NewsAgency : INewsPublisher
{
    private List<INewsSubscriber> subscribers = new List<INewsSubscriber>();

    public void AddSubscriber(INewsSubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(INewsSubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public void NotifySubscribers(string news)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(news);
        }
    }
}

// Observer
public interface INewsSubscriber
{
    void Update(string news);
}

// Concrete Observer
public class NewsSubscriber : INewsSubscriber
{
    private string name;

    public NewsSubscriber(string name)
    {
        this.name = name;
    }

    public void Update(string news)
    {
        Console.WriteLine($"{name} received news: {news}");
    }
}