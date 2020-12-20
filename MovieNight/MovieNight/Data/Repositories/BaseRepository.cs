﻿using MovieNight.Data;
using System.Threading.Tasks;

namespace MovieNight.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext db;

        public BaseRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public  void Add(TEntity entity)
        {
             db.Add<TEntity>(entity);
             db.SaveChanges();

        }


        public void Remove(TEntity entity)
        {
            db.Remove<TEntity>(entity);
            db.SaveChanges();
        }

    }
}
