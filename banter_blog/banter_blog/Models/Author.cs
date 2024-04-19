using banter_blog.Data;

namespace banter_blog.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }   

        public string Nickname { get; set; }

        public virtual ApplicationUser User { get; set; }   

        public ICollection<BlogPost>? Posts { get; set; }

        public Author( string first_Name, string last_Name, string nickname, ApplicationUser user, ICollection<BlogPost>? posts)
        {          
            First_Name = first_Name;
            Last_Name = last_Name;
            Nickname = nickname;
            User = user;
            Posts = posts;
        }
        public Author()
        {

        }
    }
}
