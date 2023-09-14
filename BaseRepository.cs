using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<T> where T:EntityBase
    {
        public virtual List<T> List()
        {
            var ctx = new Model1();
            return ctx.Set<T>().ToList();
        }

        public virtual List<T> ListActive()
        {
            var ctx = new Model1();
            return ctx.Set<T>().Where(x => x.IsActive).ToList();
        }

        public virtual void Add(T entity)
        {
            var ctx = new Model1();
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }

        public virtual void Remove(int id)
        {
            var ctx = new Model1();
            T entity = ctx.Set<T>().Find(id);
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public virtual T FintById(int id)
        {
            var ctx = new Model1();
            T entity = ctx.Set<T>().Find(id);
            return entity;
        }


    }
}
