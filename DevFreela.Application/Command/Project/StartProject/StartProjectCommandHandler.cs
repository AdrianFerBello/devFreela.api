using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.StartProject
{
    public class StartProjectCommandHandler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly IProjectRepository _projectRepository;
        public StartProjectCommandHandler(DevFreelaDbContext dbContext, IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.FirstOrDefault(x => x.Id == request.Id);

            await _projectRepository.StartAsync(project);

            return Unit.Value;
        }
    }
}
