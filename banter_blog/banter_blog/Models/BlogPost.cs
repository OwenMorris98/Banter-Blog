namespace banter_blog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public  string Title { get; set; }

        public string Body { get; set; }

        public int? Likes { get; set; }

        public DateTime? CreatedDt { get; init; } = DateTime.UtcNow;

        public Author Author { get; init; }

        public ICollection<Reaction> Reactions { get; set; }

        public ICollection<BlogComment> Comments { get; set; }

        public BlogPost Update(string title, string body)
        {
            this.Title = title;
            this.Body = body;
            return this;
        }
    }


}
