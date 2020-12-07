using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieNight.Data;
using MovieNight.Models;
using MovieNight.Models.ModelView;
using Microsoft.EntityFrameworkCore;

namespace MovieNight.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public int RoomNumber { get; set; } = 0;
        public ApplicationDbContext db { get; set; }

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            this.db = db;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string search)
        {
            /// 1
            var model = new IndexViewModel();

            var list = db.ChatRooms.Where(x => (x.Id.Contains(search) || x.Owner.Contains(search)) || (search == null)).ToList();
            model.ChatRooms = list;
            try
            {
                model.UserRole = db.Users.FirstOrDefault(x => x.UserName == HttpContext.User.Identity.Name).Role;
            }
            catch
            {
                model.UserRole = "user";
            }
            /// 2
            // ViewBag.list = list;
            /// 3
            // ViewData["list"] = list;

            return View(model);
        }

        [HttpPost]
        public IActionResult AddMovie(string movieUrl, string movieName)
        {
            db.Movies.Add(new Movie() { Name = movieName, Path = movieUrl });
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("Home/roomchat/{id}")]
        public IActionResult RoomChat(string id)
        {
            try
            {
                var room = db.ChatRooms.Include(x => x.UserChatRooms)
       .ThenInclude(x => x.User)
       .FirstOrDefault(x => x.Id == id);

                if (!room.UserChatRooms.Any(x => x.User.UserName == User.Identity.Name))
                {

                    //mapping many to many
                    UserChatRooms mapper = new UserChatRooms();
                    mapper.User = db.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                    mapper.ChatRoom = room;
                    //---

                    room.UserChatRooms.Add(mapper);
                    db.SaveChanges();

                }
                var users = db.ChatRooms.Include(x => x.UserChatRooms).ThenInclude(x => x.User)
                       .FirstOrDefault(x => x.Id == id).UserChatRooms
                       .Select(x => x.User.UserName)
                       .ToList();

                RoomChatModelView model = new RoomChatModelView();
                model.Id = id;
                model.Users = users;

                var movies = db.Movies.ToList();
                model.Movies = movies;

                return View(model);
            }
            catch
            {
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public IActionResult JoinRoom(string Id)
        {

            return RedirectToAction("RoomChat", new { Id = Id });
        }

        [HttpPost]
        public IActionResult CreateRoom()
        {
            UserChatRooms mapper = new UserChatRooms();
            using (db)
            {
                var user = db.Users.Include(x => x.UserChatRooms)
                    .ThenInclude(x => x.ChatRoom)
                    .FirstOrDefault(x => x.UserName == HttpContext.User.Identity.Name);

                //mapping many to many

                mapper.User = user;
                mapper.ChatRoom = new ChatRoom();
                mapper.ChatRoom.Owner = user.UserName;
                //---

                user.UserChatRooms.Add(mapper);
                db.SaveChanges();
            }
            //RoomNumber++;
            return RedirectToAction("RoomChat", new { Id = mapper.ChatRoomId });
        }

        [HttpGet]
        public IActionResult DeleteRoom(string id)
        {
            var room = db.ChatRooms.Include(x => x.UserChatRooms)
                                    .ThenInclude(x => x.User)
                                    .FirstOrDefault(x => x.Id == id);

            db.ChatRooms.Remove(room);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
