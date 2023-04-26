using Data.Entities.Models;
using FluentValidation;
namespace Domain.Validators
{
    public class CountriesValidator : AbstractValidator<Country>
    {
        public CountriesValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name must be at least 3 characters long");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name must be at most 50 characters long");
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Image is required");
            RuleFor(x => x.Image).MaximumLength(1000).WithMessage("Image must be at most 1000 characters long");
        }
    }

}
