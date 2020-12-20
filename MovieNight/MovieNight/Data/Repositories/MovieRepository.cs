using MovieNight.Data;
using MovieNight.Models;
using System.Linq;

namespace MovieNight.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext db;

        public MovieRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void RemoveByName(string name)
        {
            var movie = db.Movies.FirstOrDefault(x => x.Name == name);
            Remove(movie);
        }
    }
}
