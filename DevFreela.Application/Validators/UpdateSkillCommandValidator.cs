using DevFreela.Application.Command.Skills.UpdateSkill;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class UpdateSkillCommandValidator : AbstractValidator<UpdateSkillCommand>
    {
        public UpdateSkillCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .WithMessage("Id is required");

            RuleFor(x => x.Description)
                .MaximumLength(200)
                .WithMessage("Description must be at most 200 characters long");
        }
    }
}
