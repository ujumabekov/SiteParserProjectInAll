using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRWebApp.SignalRChat.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SignalRWebApp.SignalRChat.Hubs.ChatHub;

namespace SignalRWebApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public bool Get()
        {
            //var message = new ChatMessage() { user = "Server", message = $"Test {DateTime.Now.ToLongTimeString()}"};
            //var task = hub.SendMessage(message);
            //return task.Status != TaskStatus.Faulted;
            return false;
        }
    }
}
