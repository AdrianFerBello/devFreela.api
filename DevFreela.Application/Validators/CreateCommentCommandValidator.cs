using DevFreela.Application.Command.Project.CreateComment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Content is required")
                .MaximumLength(500)
                .WithMessage("Content must be at most 500 characters long");

            RuleFor(x => x.IdUser)
                .NotNull()
                .WithMessage("IdUser is required");

            RuleFor(x => x.IdFreelancer)
                .NotNull()
                .WithMessage("IdFreelancer is required");

        }
    }
}
