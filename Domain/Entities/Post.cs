using Domain.Enums;

namespace Domain.Entities
{
    public class Post : BaseRepository
    {
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Uri { get; set; }
        public string Thumbnail { get; set; }
        public string Content { get; set; }
        public long AuthorId { get; set; }
        public long? CategoryId { get; set; }

        public PostState State { get; set; }

        public virtual User Author { get; set; }
        public virtual Category Category { get; set; }
    }
}