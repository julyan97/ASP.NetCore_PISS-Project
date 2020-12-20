using MovieNight.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MovieNight.Repositories
{
    public interface IRoomRepository
    {
        ChatRoom FindRoomById(string id);
        List<ChatRoom> FindAllRoomsWhere(Expression<Func<ChatRoom, bool>> preicate);
        void RemoveRoomById(string id);
        void AddUserToRoom(User user, ChatRoom room);

        List<string> GetAllUserNamesInRoomById(string id);

    }
}
