using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using banter_blog.Models;

namespace banter_blog.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Reaction> Reactions { get; set; }

        public DbSet<BlogComment> BlogComment { get; set; }
    }
}
