using System.Collections.Generic;

namespace Domain.Entities
{
    public class Category : BaseRepository
    {
        public string Name { get; set; }
        public string Excerpt { get; set; }
        public string Uri { get; set; }
        public string Thumbnail { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}