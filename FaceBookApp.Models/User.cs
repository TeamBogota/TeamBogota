namespace FaceBookApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class User
    {
        public User()
        {
            this.Friends = new HashSet<User>();
            this.Groups = new HashSet<Group>();
        }

        public int UserId { get; set; }
        
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public DateTime Birthday { get; set; }

        public virtual Wall Wall { get; set; }

        public ICollection<User> Friends { get; set; }

        public ICollection<Group> Groups { get; set; }

        public int CreateGroup()
        {
            var group = new Group();

            return group.GroupId;
        }

        public void JoinGroup(Group group)
        {
            this.Groups.Add(group);
        }

        public void LeaveGroup(int groupId)
        {
            var group = this.Groups.FirstOrDefault(g => g.GroupId == groupId);

            this.Groups.Remove(group);
        }

        public void CreatePost(string title, string content)
        {
            var post = new Post
            {
                Title = title,
                Content = content,
                PostDate = DateTime.Now
            };

            this.Wall.Posts.Add(post);
        }

        public void EditPost(int postId, string title = "", string content = "")
        {
            var editPost = this.Wall.Posts.FirstOrDefault(p => p.PostId == postId);
            if (editPost.PostId > 0)
            {
                editPost.Title = title;
                editPost.Content = content;
                editPost.EditDate = DateTime.Now;   
            }
        }

        public void AddFriend(User friend)
        {
            this.Friends.Add(friend);
        }

        public void RemoveFriend(User friend)
        {
            this.Friends.Remove(friend);
        }
    }
}
