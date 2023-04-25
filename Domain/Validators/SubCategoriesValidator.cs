using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using FluentValidation;
namespace Domain.Validators
{
    public class SubCategoriesValidator : AbstractValidator<SubCategory>
    {
        public SubCategoriesValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name must be at most 50 characters long");
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Description must be at most 1000 characters long");
            RuleFor(x => x.Schema).NotEmpty().WithMessage("Schema is required");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category is required");
        }
    }
}
