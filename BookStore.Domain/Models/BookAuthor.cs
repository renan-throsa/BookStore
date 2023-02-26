
namespace BookApp.Domain.Models
{
    public class BookAuthor  : BaseEntity
    {
        public int BookId { get; set; } 
        public int AuthorId { get; set; } 
        public byte Order { get; set; } 

        public Book Book { get; set; }
        public Author Author { get; set; } 
    }
}
