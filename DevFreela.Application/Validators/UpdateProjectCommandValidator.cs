using DevFreela.Application.Command.Project.UpdateProject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .WithMessage("Id is required");

            RuleFor(x => x.Title)
                .MaximumLength(30)
                .WithMessage("Title must be at most 30 characters long");

            RuleFor(x => x.Description)
                .MaximumLength(200)
                .WithMessage("Description must be at most 200 characters long");
        }
    }
}
