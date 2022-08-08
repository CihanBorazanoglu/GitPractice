using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.InRepo
{
    public interface IRepository<T> /*where T : BaseEntity*/
    {
        //List Command
        List<T> GetAll();
        List<T> GetActives();

        List<T> GetUpdated();

        List<T> GetDeleted();

        //modify command

        void Add(T item);

        void AddRange(List<T> list);

        void Deleted(T item);

        void DeletedRange(List<T> list);

        void Destroy(T item);

        void DestroyRange(List<T> list);

        void Updated(T item);

        void UpdatedRange(List<T> list);

        //Linq Command

        bool Any(Expression<Func<T , bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T,object>> exp);

        List<T> Where(Expression<Func<T,bool>> exp);

        //Find 

        T Find(int id);
    }
}
