using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.DeleteProject
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly IProjectRepository _projectRepository;
        public DeleteProjectCommandHandler(DevFreelaDbContext dbContext, IProjectRepository projectRepository)
        {
            _dbContext = dbContext;
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            project.Cancel();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
