using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.database
{
    public class User
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int t_count { get; set; }
    }

    public class UserContext:DbContext
    {
        public UserContext():base("ConnectionString")
        {

        }

        public DbSet<User> Users { get; set; }
    }

    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(string id);
        void Create(T item);
        void Delete(T item);
        void Save();
    }

    public class UserRepository:IRepository<User>
    {
        private UserContext db;

        public UserRepository()
        {
            this.db = new UserContext();
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public User Get(string id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
            Save();
        }

        public void Delete(User user)
        {
            db.Users.Remove(user);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
