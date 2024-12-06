using banter_blog.Migrations;

namespace banter_blog.Models
{
    public class BlogPostsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public int? Likes { get; set; }

        public bool isLiked { get; set; }

        public DateTime? CreatedDt { get; set; } = DateTime.UtcNow;

        public Author Author { get; set; }

        public ICollection<Reaction> Reactions { get; set; }

        public ICollection<BlogComment> Comments { get; set; }
    }
}
