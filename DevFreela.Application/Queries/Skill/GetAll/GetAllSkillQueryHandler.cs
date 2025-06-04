using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Skill.GetAll
{
    public class GetAllSkillQueryHandler : IRequestHandler<GetAllSkillQuery, List<SkillsViewModel>>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetAllSkillQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillsViewModel>> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
        {
            var skills = _dbContext.Skills;

            var listSkillsViewModel = skills
                .Select(x => new SkillsViewModel(x.Id, x.Description))
                .ToList();

            return listSkillsViewModel;
        }
    }
    
}
