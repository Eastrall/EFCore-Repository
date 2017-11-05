using EFCore.Repository.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Repository.DAL.Repository
{
    public class PersonRepository : RepositoryBase<Person>
    {
        public PersonRepository(DbContext context)
            : base(context)
        {
        }
    }
}