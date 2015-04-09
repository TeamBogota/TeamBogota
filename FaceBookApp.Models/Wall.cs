namespace FaceBookApp.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Wall
    {
        public Wall()
        {
            this.Posts = new HashSet<Post>();
        }

        public int WallId { get; set; }

        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual User User { get; set; }
    }
}
