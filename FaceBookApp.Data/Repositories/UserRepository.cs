using System.Linq;

namespace FaceBookApp.Data.Repositories
{
    using Models;

    public class UserRepository : Repository<User>, IUsersRepository
    {
        public UserRepository(IFaceBookAppDbContext context)
            : base(context)
        {
        }

        public IQueryable<User> AllUsers()
        {
            return this.All();
        }

        public IQueryable<User> AllByGender(Gender gender)
        {
            return this.All().Where(u => u.Gender == gender);
        }

        public User GetUserByUsername(string username)
        {
            return this.All().FirstOrDefault(u => u.Username == username);
        }
    }
}
