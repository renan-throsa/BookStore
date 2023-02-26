using BookApp.Data.Interfaces;
using BookApp.Domain.Models;

namespace BookStore.Data.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
    }
}
