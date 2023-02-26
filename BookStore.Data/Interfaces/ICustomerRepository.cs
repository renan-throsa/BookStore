using BookApp.Data.Interfaces;
using BookApp.Domain.Models;
using System.Threading.Tasks;

namespace BookStore.Data.Interfaces
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Task<Customer> GetByIdAsync(int id, bool withReviews = false, bool withOrders = false);
    }
}
