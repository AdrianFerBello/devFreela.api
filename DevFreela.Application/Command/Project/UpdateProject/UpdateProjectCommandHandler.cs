using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly IProjectRepository _projectRepository;
        public UpdateProjectCommandHandler(DevFreelaDbContext dbContext, IProjectRepository projectRepository )
        {
            _dbContext = dbContext;
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            project.Update(request.Title, request.Description, request.TotalCost);

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
