using DevFreela.Application.ViewModels;
using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Project.GetAll
{
    public class GetAllProjectQueryHandler : IRequestHandler<GetAllProjectQuery, List<ProjectViewModel>>
    {
        private readonly IProjectRepository _projectRepository;
        public GetAllProjectQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<ProjectViewModel>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var projects = await _projectRepository.GetAllAsync();

            var listProjectViewModel = projects
                .Select(x => new ProjectViewModel(x.Id, x.Title, x.CreateAt))
                .ToList();

            return listProjectViewModel;
        }
    }
}
