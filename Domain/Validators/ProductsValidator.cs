using Data.Entities.Models;
using FluentValidation;
namespace Domain.Validators
{
    public class ProductsValidator : AbstractValidator<Product>
    {

        public ProductsValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name must be unique");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price is required");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity is required");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category is required");
            RuleFor(x => x.SubCategoryId).NotEmpty().WithMessage("SubCategory is required");
            RuleFor(x => x.LocationId).NotEmpty().WithMessage("Location is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Description).MaximumLength(100).WithMessage("Description must be less than 100 characters");
            RuleFor(x => x.Images).NotEmpty().WithMessage("Image is required");
            RuleFor(x => x.Images).Must(x => x.Count() <= 5).WithMessage("You can upload maximum 5 images");
            RuleFor(x => x.Images).Must(x => x.Count() >= 1).WithMessage("You must upload at least 1 image");
            RuleFor(x => x.Created).LessThanOrEqualTo(DateTime.Now);
        }
    }
}
