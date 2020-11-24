using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.ChatHub
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string room , string message)
        {
            
            await Clients.All.SendAsync("ReceiveMessage", new { User = Context.User.Identity.Name, Text = message});
            
        }

        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);

            await Clients.Group(room).SendAsync("ReceiveMessage", $"{Context.User.Identity.Name} has joined the group {room}.");
        }

        public async Task SendMessageToGroup(string room, string message)
        {

            await Clients.Groups(room).SendAsync("ReceiveMessage", new { User = Context.User.Identity.Name, Text = message });
        }


        public async Task SendMessageToUser(string user, string message)
        {

            await Clients.User(user).SendAsync("ReceiveMessage", new { User = Context.User.Identity.Name, Text = message });
        }

    }
}
