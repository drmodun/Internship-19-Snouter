using Data.Entities.Models;
using FluentValidation;
namespace Domain.Validators
{
    public class BuyersProductsValidator : AbstractValidator<BuyersProducts>
    {
        public BuyersProductsValidator()
        {
            RuleFor(x => x.BuyerId).NotEmpty().WithMessage("Buyer is required");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product is required");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity is required");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0");

        }
    }
}
