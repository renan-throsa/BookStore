using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Domain.Models
{
    public class Tag : BaseEntity
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        [MaxLength(40)]
        public string TagName { get; set; }

        public ICollection<BookTag> Books { get; set; }
    }
}
