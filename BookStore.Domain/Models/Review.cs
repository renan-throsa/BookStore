
using System;

namespace BookApp.Domain.Models
{
    public class Review : BaseEntity
    {
        public int ReviewId { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedOn { get; }
    }
}
