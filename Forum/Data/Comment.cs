using Microsoft.VisualBasic;

namespace Forum.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string ForumUserId { get; set; }
        public string CommentText { get; set; }
        public DateTime Created { get; set; }
        public ForumUser ForumUser { get; set; }
        public Post Post { get; set; }
    }
}
