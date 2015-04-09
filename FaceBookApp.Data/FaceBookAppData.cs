namespace FaceBookApp.Data
{
    using System;
    using System.Collections.Generic;

    using Models;   
    using Repositories;

    public class FaceBookAppData : IFaceBookAppData
    { 
        private IFaceBookAppDbContext context;
        private IDictionary<Type, object> repositories; 

        public FaceBookAppData(IFaceBookAppDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IFaceBookAppDbContext Context
        {
            get { return this.context; }
        }

        public IUsersRepository Users
        {
            get { return (IUsersRepository)this.GetRepository<User>(); }
        }

        public IRepository<Post> Posts
        {
            get { return new Repository<Post>(this.context); }
        }

        public IRepository<Comment> Comments
        {
            get { return new Repository<Comment>(this.context); }
        }

        public IRepository<Wall> Walls
        {
            get { return new Repository<Wall>(this.context); }
        }

        public IRepository<Group> Groups
        {
            get { return new Repository<Group>(this.context); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<T>);
                if (typeof(T).IsAssignableFrom(type))
                {
                    repositoryType = typeof(UserRepository);
                }

                this.repositories.Add(typeof(T), Activator.CreateInstance(repositoryType, this.context));
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}
