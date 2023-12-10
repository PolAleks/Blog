using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // Внешний ключ
        public List<Post>? Posts { get; set; }
    }
}
