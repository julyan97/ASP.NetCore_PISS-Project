using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.Repositories
{

    public interface IBaseRepository<SetType>
    {
        void Add(SetType entity);
        void Remove(SetType entity);


    }
}
