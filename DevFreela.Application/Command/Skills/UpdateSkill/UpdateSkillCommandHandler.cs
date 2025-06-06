using DevFreela.Core.Repository;
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
        private readonly ISkillRepository _skillRepository;
        public UpdateSkillCommandHandler(DevFreelaDbContext dbContext, ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
        {
            var skill = await _skillRepository.GetByIdAsync(request.Id);

            skill.Update(request.Description);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
