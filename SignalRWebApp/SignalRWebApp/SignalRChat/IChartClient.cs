using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SignalRWebApp.SignalRChat.Hubs.ChatHub;

namespace SignalRWebApp.SignalRChat
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
