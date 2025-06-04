using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Skill.GetById
{
    public class GetByIdSkillQueryHandler : IRequestHandler<GetByIdSkillQuery, SkillDetailsViewModel>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetByIdSkillQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SkillDetailsViewModel> Handle(GetByIdSkillQuery request, CancellationToken cancellationToken)
        {
            var skill = _dbContext.Skills.FirstOrDefault(x => x.Id == request.Id);

            var detailsViewModel = new SkillDetailsViewModel(skill.Id, skill.Description, skill.CreateAt);

            return detailsViewModel;

        }
    }
}
