using banter_blog.Data;

namespace banter_blog.Models
{
    public class Reaction
    {
        public int Id { get; set; }

        public virtual BlogPost Post { get; set; }

        public virtual ApplicationUser User { get; set; }


    }
}
