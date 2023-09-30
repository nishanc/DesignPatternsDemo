// Service
public interface IMessageService
{
    void SendMessage(string message);
}

// Concrete Service
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

// Client
public class MessageClient
{
    private IMessageService messageService;

    // Dependency is injected through constructor
    public MessageClient(IMessageService messageService)
    {
        this.messageService = messageService;
    }

    public void SendNotification(string message)
    {
        messageService.SendMessage(message);
    }
}