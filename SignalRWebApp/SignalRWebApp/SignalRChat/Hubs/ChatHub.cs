using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRWebApp.SignalRChat.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public class ChatMessage
        {
            public string user { get; set; }
            public string message { get; set; }

        }
        public async Task SendMessage (ChatMessage msg)
        {
            await Clients.All.ReceiveMessage(msg); 
        }
    }
}
