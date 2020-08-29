using System;

namespace Domain.Entities
{
    public abstract class BaseRepository
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}