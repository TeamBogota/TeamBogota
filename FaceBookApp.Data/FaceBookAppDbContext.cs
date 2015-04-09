namespace FaceBookApp.Data
{
    using System.Data.Entity;

    using Migrations;
    using Models;

    public class FaceBookAppDbContext : DbContext
    {
        public FaceBookAppDbContext()
            : base("FaceBookAppConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FaceBookAppDbContext, Configuration>());
        }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Wall> Walls { get; set; }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Group> Groups { get; set; }
    }
}
