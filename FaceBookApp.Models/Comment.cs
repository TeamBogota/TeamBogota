namespace FaceBookApp.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
