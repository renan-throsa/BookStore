using BookApp.Data.Repositories;
using BookApp.Domain.Models;
using BookStore.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BookAppContext context) : base(context)
        {
        }

        public async Task<Customer> GetByIdAsync(int id, bool withReviews = false, bool withOrders = false)
        {
            var query = _currentSet.AsNoTracking();
            if (withReviews) query = query.Include(x => x.Reviews);
            if (withOrders) query = query.Include(x => x.Orders);
            return await query.FirstOrDefaultAsync(x => x.CustomerId == id);
        }

        public override async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _currentSet.AsNoTrackingWithIdentityResolution().ToListAsync();
        }

    }
}
