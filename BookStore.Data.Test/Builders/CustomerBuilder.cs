using Bogus;
using BookApp.Domain.Models;
using System.Collections.Generic;
namespace BookStore.Data.Test.Builders
{
    public class CustomerBuilder
    {
        private readonly Faker _faker;

        private int CustomerId { get; set; }

        private string FirstName { get; set; }

        private string LastName { get; set; }

        private string FullName { get; set; }

        private string Email { get; set; }

        private ICollection<Review> Reviews { get; set; }

        private ICollection<Order> Orders { get; set; }

        public CustomerBuilder()
        {
            _faker = new Faker();
        }



        public CustomerBuilder WithFirstName(string firstName = null)
        {
            FirstName = string.IsNullOrEmpty(firstName) ? _faker.Name.FirstName() : firstName;
            return this;
        }

        public CustomerBuilder WithLastName(string lastName = null)
        {
            FirstName = string.IsNullOrEmpty(lastName) ? _faker.Name.LastName() : lastName;
            return this;
        }

        /// <summary>
        /// Generates a valid email and assigns it to a private property. For a better result, call this method after calling <c>CustomerBuilder.WithFirstName()</c> and <c>CustomerBuilder.WithLastName()</c>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public CustomerBuilder WithEmail(string email = null)
        {
            Email = string.IsNullOrEmpty(email) ? _faker.Internet.Email(FirstName, LastName) : email;
            return this;
        }

        public Customer Build() { return new Customer() { }; }
    }
}
