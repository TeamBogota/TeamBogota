namespace FaceBookApp.Data
{
    using Models;
    using Repositories;

    public interface IFaceBookAppData
    {
        IUsersRepository Users { get; }

        IRepository<Post> Posts { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Wall> Walls { get; }

        IRepository<Group> Groups { get; } 

        int SaveChanges();
    }
}
