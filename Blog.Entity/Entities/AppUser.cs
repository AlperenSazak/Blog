using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("12ba7a58-dc12-463c-bdad-b7dafb7b21c1");

        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
