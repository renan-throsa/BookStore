using BookApp.Data.Repositories;
using BookApp.Domain.Models;
using BookStore.Data.Interfaces;

namespace BookStore.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(BookAppContext context) : base(context)
        {
        }
    }
}
