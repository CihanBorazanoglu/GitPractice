using Project.BLL.DesingPatterns.GenericRepository.InRepo;
using Project.BLL.DesingPatterns.SingletonPattern;
using Project.DAL.Context;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.BaseRepo
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity , new()
    {
        MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DbInstance;
        }
        void Save()
        {
            _db.SaveChanges();
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Deleted(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.Status = DataStatus.Deleted;

            Save();
        }

        public void DeletedRange(List<T> list)
        {
            foreach (T item in list)
            {
                Deleted(item);
            }
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetDeleted()
        {
            return Where(x=> x.Status == DataStatus.Deleted);
        }

        public List<T> GetUpdated()
        {
            return Where(x=> x.Status == DataStatus.Updated);
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public void Updated(T item)
        {
            item.UpdateDate = DateTime.Now;
            item.Status= DataStatus.Updated;

            T guncellenecek = Find(item.ID);

            _db.Entry(guncellenecek).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdatedRange(List<T> list)
        {
            foreach (T item in list)
            {
                UpdatedRange(item);
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
