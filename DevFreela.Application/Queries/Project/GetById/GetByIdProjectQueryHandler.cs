using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Project.GetById
{
    public class GetByIdProjectQueryHandler : IRequestHandler<GetByIdProjectQuery, ProjectDetailsViewModel>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetByIdProjectQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProjectDetailsViewModel> Handle(GetByIdProjectQuery request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects
                .Include(x => x.Cliente)
                .Include(x => x.Freelancer)
                .FirstOrDefault(x => x.Id == request.Id);

            var projectDetails = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.TotalCost,
                project.CreateAt,
                project.Status,
                project.Cliente.Name,
                project.Freelancer.Name);

            return projectDetails;
        }
    }
}
