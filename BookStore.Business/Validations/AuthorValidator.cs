using BookApp.Domain.Models;
using FluentValidation;

namespace BookStore.Business.Validations
{
    internal class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {

        }
    }
}
