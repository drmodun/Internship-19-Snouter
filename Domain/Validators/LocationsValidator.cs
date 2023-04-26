using Data.Entities.Models;
using FluentValidation;
namespace Domain.Validators
{
    public class LocationsValidator : AbstractValidator<Location>
    {
        public LocationsValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name must be at most 50 characters long");
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");
            RuleFor(x => x.Latitude).NotEmpty().WithMessage("Latitude is required");
            RuleFor(x => x.Longitude).NotEmpty().WithMessage("Longitude is required");
            //write coonstraints regarding latitude and longitude


        }
    }
}
