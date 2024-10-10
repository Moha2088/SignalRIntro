namespace SignalRIntro.Hubs
{
    public interface IChatClient
    {
       public Task ReceiveMessage(string message);
    }
}
