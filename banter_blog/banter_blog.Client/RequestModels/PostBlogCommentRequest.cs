
namespace banter_blog.Client.RequestModels;

public class PostBlogCommentRequest
{
    public PostBlogCommentRequest()
    {
    }

    public Guid CommentId { get; init; } = Guid.NewGuid();

    public string Comment { get; set; }

    public string ApplicationUserId { get; set; }

    public int BlogPostId { get; set; }

    public PostBlogCommentRequest(string comment, string applicationUserId, int blogPostId)
    {
        Comment = comment;
        ApplicationUserId = applicationUserId;
        BlogPostId = blogPostId;
    }
}
