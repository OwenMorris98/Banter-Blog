using banter_blog.Migrations;
using banter_blog.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Hosting;

namespace banter_blog.Mappers
{
    public static class BlogPostMapper
    {
        public static BlogPostsViewModel toViewmodel(this BlogPost blogPost)
        {
            return new BlogPostsViewModel
            {
                Id = blogPost.Id,
                Title = blogPost.Title,
                Body = blogPost.Body,
                Author = blogPost.Author,
                CreatedDt = blogPost.CreatedDt,
                Reactions = blogPost.Reactions,
                Comments = blogPost.Comments,
                Likes = blogPost.Reactions.Count()
            };
                
              
        }
    }

}
