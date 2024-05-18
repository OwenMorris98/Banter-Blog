using banter_blog.Data;
using Npgsql.Replication;

namespace banter_blog.Models
{
    public class BlogComment
    { 
        public int Id { get; set; }

        public Guid CommentId { get; init; } = Guid.NewGuid();

        public string Comment { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public BlogPost BlogPost { get; set; }

        public BlogComment(string comment, ApplicationUser applicationUser, BlogPost blogPost)
        {
            
            CommentId = Guid.NewGuid();
            Comment = comment;
            ApplicationUser = applicationUser;
            BlogPost = blogPost;

        }

        public BlogComment AddFromPost(string comment, ApplicationUser user, BlogPost blogPost)
        {
            this.Comment = comment;
            this.ApplicationUser = user;
            this.BlogPost = blogPost;
            return this;
        }

        public BlogComment()
        {
        }
    }
}
