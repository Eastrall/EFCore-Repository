using EFCore.Repository.DAL.Entity;
using EFCore.Repository.DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Repository.DAL
{
    public class DatabaseContext : DbContext
    {
        private readonly string _host;
        private readonly string _databaseName;

        // Note that we renamed this proprety to avoid conflicts
        public DbSet<Person> DbPersons { get; set; }

        public IRepository<Person> Persons { get; }

        public DatabaseContext(string host, string databaseName)
        {
            this._host = host;
            this._databaseName = databaseName;
            this.Persons = new PersonRepository(this);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={this._host};Database={this._databaseName};Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
