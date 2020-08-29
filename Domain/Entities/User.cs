using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class User : IdentityUser<long>
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Uri { get; set; }
        public string Excerpt { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}