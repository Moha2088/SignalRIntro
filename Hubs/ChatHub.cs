using Microsoft.AspNetCore.SignalR;

namespace SignalRIntro.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessage",$"Hello {Context.ConnectionId}. Thank you for connecting!");
        }
    }
}
