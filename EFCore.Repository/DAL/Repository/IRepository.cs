using System.Collections.Generic;

namespace EFCore.Repository.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        IEnumerable<T> GetAll();
    }
}

