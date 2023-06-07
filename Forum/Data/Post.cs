using Microsoft.VisualBasic.CompilerServices;

namespace Forum.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Introduction{ get; set; }
        public string BodyText { get; set; }
        public string Image { get; set; }

        //public DateType CreationDate { get; set; }
    }
}
