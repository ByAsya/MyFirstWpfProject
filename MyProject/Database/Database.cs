namespace MyProject.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class Data : DbContext
    {
        public Data()
            : base("name=Database1")
        {
        }

        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Topic1)
                .HasForeignKey(e => e.topic);
        }

        interface IRepository<T> where T : class
        {
            IEnumerable<T> GetAll();
            T Get(string id);
            void Create(T item);
            void Delete(T item);
            void Save();
        }

        public class UserRepository : IRepository<User>
        {
            private Data db;

            public UserRepository()
            {
                this.db = new Data();
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

        public class TaskRepository : IRepository<Task>
        {
            private Data db;

            public TaskRepository()
            {
                this.db = new Data();
            }

            public IEnumerable<Task> GetAll()
            {
                return db.Tasks;
            }

            public Task Get(string id)
            {
                return db.Tasks.Find(id);
            }

            public void Create(Task task)
            {
                db.Tasks.Add(task);
                Save();
            }

            public void Delete(Task task)
            {
                db.Tasks.Remove(task);
                Save();
            }

            public void Save()
            {
                db.SaveChanges();
            }
        }

        public class TopicRepository : IRepository<Topic>
        {
            private Data db;

            public TopicRepository()
            {
                this.db = new Data();
            }

            public IEnumerable<Topic> GetAll()
            {
                return db.Topics;
            }

            public Topic Get(string id)
            {
                return db.Topics.Find(id);
            }

            public void Create(Topic topic)
            {
                db.Topics.Add(topic);
                Save();
            }

            public void Delete(Topic topic)
            {
                db.Topics.Remove(topic);
                Save();
            }

            public void Save()
            {
                db.SaveChanges();
            }
        }
    }
}
