using DevFreela.Application.Command.Project.CreateProject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .WithMessage("Title is required");

            RuleFor(x => x.Description)
                .MaximumLength(200)
                .WithMessage("Description must be at most 50 characters long");

            RuleFor(x => x.IdClient)
                .NotNull()
                .WithMessage("IdClient not null");

            RuleFor(x => x.IdFreelancer)
                .NotNull()
                .WithMessage("IdFreelancer not null");
        }
    }
}
