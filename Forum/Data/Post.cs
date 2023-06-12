using System.ComponentModel.DataAnnotations;

namespace Forum.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string ForumUserId { get; set; }
        [StringLength(255, MinimumLength = 8)]
        [Required(ErrorMessage = "Tytuł wymagany")]
        public string Title { get; set; }
        [StringLength(255, MinimumLength = 10)]
        [Required(ErrorMessage = "Krótki opis wymagany")]
        public string Introduction{ get; set; }
        [StringLength(4000, MinimumLength = 10)]
        [Required(ErrorMessage = "Treść postu nie może być pusta")]
        public string BodyText { get; set; }
        [Required(ErrorMessage = "By ten post mógł bardziej rzucić się w oczy dodaj do niego jakiś fajny obraz ;)")]
        public string Image { get; set; }
        public DateTime Created { get; set; }
        public ForumUser ForumUser { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
