// Subject
public interface IInternet
{
    void ConnectTo(string serverHost);
}

// Real Subject
public class RealInternet : IInternet
{
    public void ConnectTo(string serverHost)
    {
        Console.WriteLine($"Connecting to {serverHost}");
    }
}

// Proxy
public class InternetProxy : IInternet
{
    private RealInternet realInternet = new RealInternet();
    private List<string> blockedSites = new List<string> { "blocked.com", "malicious.org" };

    public void ConnectTo(string serverHost)
    {
        if (blockedSites.Contains(serverHost.ToLower()))
        {
            Console.WriteLine($"Access to {serverHost} is blocked.");
        }
        else
        {
            realInternet.ConnectTo(serverHost);
        }
    }
}