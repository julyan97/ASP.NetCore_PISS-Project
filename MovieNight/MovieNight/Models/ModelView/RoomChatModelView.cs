using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.Models.ModelView
{
    public class RoomChatModelView
    {
        public string Id { get; set; }
        public List<int> List { get; set; } = new List<int>() { 1, 2, 3, 4, 5, 6 };
    }
}
