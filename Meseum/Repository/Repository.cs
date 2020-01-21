using Meseum.IRepository;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System;
using Meseum.DAL;
using System.Threading.Tasks;

namespace Meseum.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected MeseumContext db;

        public Repository(MeseumContext Context)
        {
            db = Context;
        }
        public void Delete(int id)
        {
           T model= db.Set<T>().Find(id);
            db.Set<T>().Remove(model);
            Save();
        }

        

        public virtual async Task<T> GetById(int id)
        {
            var data = await db.Set<T>().FindAsync(id);
            return data;
        }

        public virtual async Task<IEnumerable<T>> GetModel()
        {
            return await db.Set<T>().ToListAsync();

        }

        public void Insert(T Model)
        {
            db.Set<T>().Add(Model);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T Model)
        {
            db.Entry(Model).State = EntityState.Modified;
            Save();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
         
            return this.db.Set<T>().Where(expression).AsNoTracking();
        }

    }
}