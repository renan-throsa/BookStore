using BookApp.Data.Interfaces;
using BookApp.Data.Repositories;
using BookApp.Domain.Models;
using BookStore.Data.Interfaces;
using BookStore.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BookStore.Data.Test.Fixtures
{
    public class RepositoryFixture : IDisposable
    {
        private readonly ServiceProvider _serviceProvider;

        public RepositoryFixture()
        {
            var services = new ServiceCollection();

            services.AddDbContext<BookAppContext>(options => options
                        .UseSqlServer(GetApiConnectionString()).EnableSensitiveDataLogging()
                        .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information));


            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            _serviceProvider = services.BuildServiceProvider();
        }

        public void Dispose()
        {
            _serviceProvider.Dispose();
        }

        public T GetRequiredRepository<T>() => _serviceProvider.GetRequiredService<T>();

        private string GetApiConnectionString() => "Server=.\\SQLEXPRESS;Database=BookApp;Trusted_Connection=True;";
    }
}
