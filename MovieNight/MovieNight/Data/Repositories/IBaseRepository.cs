using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.Repositories
{

    public interface IBaseRepository<TEntity>
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);


    }
}
