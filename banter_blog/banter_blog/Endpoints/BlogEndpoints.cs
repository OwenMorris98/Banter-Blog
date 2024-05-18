using banter_blog.Client.RequestModels;
using banter_blog.Data;
using banter_blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace banter_blog.Endpoints
{
    public static class BlogEndpoints
    {
        public static void RegisterBlogEndpoints(this WebApplication app)
        {
            app.MapPost("/Comment/", async (PostBlogCommentRequest reqComment, ApplicationDbContext db) =>
            {
                // Ensure the user exists
                var user = await db.Users.FindAsync(reqComment.ApplicationUserId);
                if (user == null)
                {
                    return Results.BadRequest("User not found.");
                }

                // Ensure the blog post exists
                var blogPost = await db.BlogPosts.FindAsync(reqComment.BlogPostId);
                if (blogPost == null)
                {
                    return Results.BadRequest("Blog post not found.");
                }

                // Create a new comment
                var comment = new BlogComment
                {
                    Comment = reqComment.Comment,
                    ApplicationUser = user,
                    BlogPost = blogPost,

                };

                // Add the comment to the database
                db.BlogComment.Add(comment);
                await db.SaveChangesAsync();

                return Results.Ok(comment);
            });

            //var response = await _request.PutAsync($"/PutUsername/{userId}/", requestParam);

            app.MapPut("/PutUsername/{Id}/", async (string Id, EditUserNameDialogParams request, ApplicationDbContext db) =>
            {
                
                var user = await db.Users.FindAsync(Id);
                if (user == null)
                {
                    return Results.BadRequest("User not found.");
                }
                user.UserName = request.userName;
                await db.SaveChangesAsync();

                return Results.Ok();
            });
        }
    }
}
