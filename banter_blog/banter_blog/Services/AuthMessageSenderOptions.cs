using System;
namespace banter_blog.Services
{
    public class AuthMessageSenderOptions
    {
        public string? SendGridKey { get; set; } = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");

        
    }
}
