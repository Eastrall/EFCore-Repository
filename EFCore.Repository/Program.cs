using EFCore.Repository.DAL;
using EFCore.Repository.DAL.Entity;

namespace EFCore.Repository
{
    class Program
    {
        private static readonly string Host = "host";
        private static readonly string DatabaseName = "repository";

        static void Main(string[] args)
        {
            using (var db = new DatabaseContext(Host, DatabaseName))
            {
                db.Database.EnsureCreated();

                var person = new Person
                {
                    FirstName = "Filipe",
                    LastName = "GP",
                    Age = 23
                };

                db.Persons.Add(person);
            }
        }
    }
}
