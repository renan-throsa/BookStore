using BookStore.Data.Interfaces;
using BookStore.Data.Test.Fixtures;
using Xunit;

namespace BookStore.Data.Test.Tests
{
    [Collection(nameof(RepositoryCollection))]
    public class CustomerTests
    {
        private readonly ICustomerRepository _repository;

        public CustomerTests(RepositoryFixture fixture)
        {
            _repository = fixture.GetRequiredRepository<ICustomerRepository>();
        }

        [Fact]
        public async void GetById_ShouldReturnOk()
        {
            var customer = await _repository.GetByIdAsync(1);

            Assert.NotNull(customer);
            Assert.Equal("John Smith", customer.FullName);
        }

        [Fact]
        public async void GetAll_ShouldReturnOk()
        {
            var list = await _repository.GetAllAsync();
            Assert.NotNull(list);
        }

        [Fact]
        public async void GetAll_WithRelaionship_ShouldReturnOk()
        {
            var customer = await _repository.GetByIdAsync(1, withOrders: true, withReviews: true);
            Assert.NotNull(customer);
            Assert.NotEmpty(customer.Orders);
            Assert.NotEmpty(customer.Reviews);

        }

    }
}
