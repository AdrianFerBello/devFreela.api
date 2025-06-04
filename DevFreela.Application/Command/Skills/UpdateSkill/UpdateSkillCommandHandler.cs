using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Skills.UpdateSkill
{
    public class UpdateSkillCommandHandler : IRequestHandler<UpdateSkillCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public UpdateSkillCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            var skill = _dbContext.Skills.SingleOrDefault(x => x.Id == request.Id);

            skill.Update(request.Description);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
