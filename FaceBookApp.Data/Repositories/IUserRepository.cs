namespace FaceBookApp.Data.Repositories
{
    using System.Linq;

    using Models;

    public interface IUsersRepository : IRepository<User>
    {
        IQueryable<User> AllUsers();

        IQueryable<User> AllByGender(Gender gender);

        User GetUserByUsername(string username);
    }
}
