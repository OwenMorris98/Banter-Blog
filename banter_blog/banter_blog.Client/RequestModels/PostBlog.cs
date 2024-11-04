namespace banter_blog.Client.RequestModels;

public record PostBlogRequest(string title, string body, int authorId);