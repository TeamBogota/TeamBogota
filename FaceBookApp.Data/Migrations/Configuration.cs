namespace FaceBookApp.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<FaceBookAppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "FaceBookApp.Data.FaceBookAppDbContext";
        }

        protected override void Seed(FaceBookAppDbContext context)
        {
        }
    }
}
