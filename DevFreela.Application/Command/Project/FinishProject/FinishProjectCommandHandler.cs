using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.FinishProject
{
    public class FinishProjectCommandHandler : IRequestHandler<FinishProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly IProjectRepository _projectRepository;
        public FinishProjectCommandHandler(DevFreelaDbContext dbContext, IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            project.Finish();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
