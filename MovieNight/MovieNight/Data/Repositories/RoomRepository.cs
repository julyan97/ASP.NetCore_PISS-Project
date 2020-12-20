using Microsoft.EntityFrameworkCore;
using MovieNight.Data;
using MovieNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MovieNight.Repositories
{
    public class RoomRepository : BaseRepository<ChatRoom>, IRoomRepository
    {
        private readonly ApplicationDbContext db;

        public RoomRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void AddUserToRoom(User user, ChatRoom room)
        {
            //mapping many to many
            UserChatRooms mapper = new UserChatRooms();
            mapper.User = user;
            mapper.ChatRoom = room;
            //---

            room.UserChatRooms.Add(mapper);
            db.SaveChanges();
        }

        public List<ChatRoom> FindAllRoomsWhere(Expression<Func<ChatRoom, bool>> predicate)
        {

            var list = db.ChatRooms
                .Include(x => x.UserChatRooms)
                .ThenInclude(x => x.User)
                .Where(predicate)
                .ToList();

            return list;
        }

        public ChatRoom FindRoomById(string id)
        {
            var room = db.ChatRooms.Include(x => x.UserChatRooms)
                    .ThenInclude(x => x.User)
                    .FirstOrDefault(x => x.Id == id);

            return room;
        }

        public List<string> GetAllUserNamesInRoomById(string id)
        {
            var room = FindRoomById(id);
            var list = room.UserChatRooms.Select(x => x.User.UserName).ToList();
            return list;
        }

        public void RemoveRoomById(string id)
        {
            var room = db.ChatRooms.FirstOrDefault(x => x.Id == id);
            Remove(room);
        }
    }
}
