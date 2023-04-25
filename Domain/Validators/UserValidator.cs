using Data.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("First name is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters long");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Password must be at most 20 characters long");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not in a valid format");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email must be at most 50 characters long");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("First name must be at most 50 characters long");
            RuleFor(x => x.CreatedAt).LessThanOrEqualTo(DateTime.Now).WithMessage("Error on date add");
            RuleFor(x => x.UpdatedAt).GreaterThanOrEqualTo(x => x.CreatedAt);
            RuleFor(x=>x.AddressId).NotEmpty().WithMessage("Address is required");

        }
    }
}
