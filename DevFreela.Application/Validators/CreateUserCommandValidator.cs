using DevFreela.Application.Command.User.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email is not valid");

            RuleFor(x => x.Password)
                .Must(ValidPassword)
                .WithMessage("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");

            RuleFor(x => x.Name)
                .NotEmpty() //nao pode ser vazio
                .NotNull() //nao pode ser nulo  
                .WithMessage("Name is required");

        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$");

            return regex.IsMatch(password);

        }
    }
}
