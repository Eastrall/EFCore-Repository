using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCore.Repository.DAL.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        protected RepositoryBase(DbContext context)
        {
            this._context = context;
        }

        public void Add(T entity)
        {
            this._context.Set<T>().Add(entity);
            this._context.SaveChanges();
        }

        public void Delete(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>();
        }

        public void Update(T entity)
        {
            this._context.Set<T>().Update(entity);
            this._context.SaveChanges();
        }
    }
}