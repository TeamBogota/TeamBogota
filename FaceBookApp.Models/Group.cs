namespace FaceBookApp.Models
{
    using System.Collections.Generic;

    public class Group
    {
        public Group()
        {
            this.Users = new HashSet<User>();
        }

        public int GroupId { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
