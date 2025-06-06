using DevFreela.Core.Entities;
using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.CreateProject
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        private readonly IProjectRepository _projectRepository;
        public CreateProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Core.Entities.Project (request.Title, request.Description, request.IdClient, request.IdFreelancer, request.TotalCost);

            await _projectRepository.CreateAsync(project);

            return project.Id;
        }
    }
    
}
