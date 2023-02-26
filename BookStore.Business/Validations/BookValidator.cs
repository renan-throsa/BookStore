using BookApp.Domain.Models;
using BookStore.Domain.Enums;
using FluentValidation;

namespace BookStore.Business.Validations
{
    internal class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleSet(OperationTypeEnum.Default.ToString(), () =>
            {

                RuleFor(m => m.ISBN).Matches(@"^(97(8|9))?\d{9}(\d|X)$");
                RuleFor(m => m.Title).Matches(@"^\w.*.{0,127}$").WithMessage("O número de telefone deve ter exatamente 11 caracteres.");
                RuleFor(m => m.Description).Matches(@"^\w.*.{0,511}$").WithMessage("O número de telefone deve ter exatamente 11 caracteres.");
                RuleFor(m => m.Publisher).Matches(@"^\w.*.{0,63}$").WithMessage("O número de telefone deve ter exatamente 11 caracteres.");
                RuleFor(m => m.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
                RuleFor(m => m.Authors).NotEmpty().WithMessage("A book mut have at least one author.");

            });

            RuleSet(OperationTypeEnum.Insert.ToString(), () =>
            {
                RuleFor(m => m.BookId).Equal(0);

            });

            RuleSet(OperationTypeEnum.Update.ToString(), () =>
            {
                RuleFor(m => m.BookId).GreaterThan(0);

            });

            RuleSet(OperationTypeEnum.Delete.ToString(), () =>
            {
                RuleFor(m => m.BookId).GreaterThan(0);
            });
        }
    }
}
