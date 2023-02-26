using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Domain.Models
{
    public class Author : BaseEntity
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string WebUrl { get; set; }

        public ICollection<BookAuthor> Books { get; set; }
    }
}
