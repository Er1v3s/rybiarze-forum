namespace Forum.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string ForumUserId { get; set; }
        public string Title { get; set; }
        public string Introduction{ get; set; }
        public string BodyText { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }
        public ForumUser ForumUser { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
