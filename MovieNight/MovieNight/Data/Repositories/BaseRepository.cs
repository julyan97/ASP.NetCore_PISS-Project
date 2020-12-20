using MovieNight.Data;
using System.Threading.Tasks;

namespace MovieNight.Repositories
{
    public class BaseRepository<SetType> : IBaseRepository<SetType> where SetType : class
    {
        private readonly ApplicationDbContext db;

        public BaseRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public  void Add(SetType entity)
        {
             db.Add<SetType>(entity);
             db.SaveChanges();

        }


        public void Remove(SetType entity)
        {
            db.Remove<SetType>(entity);
            db.SaveChanges();
        }

    }
}
