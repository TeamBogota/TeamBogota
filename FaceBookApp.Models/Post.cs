using System;
using System.Collections.Generic;

namespace FaceBookApp.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PostDate { get; set; }

        public DateTime EditDate { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
