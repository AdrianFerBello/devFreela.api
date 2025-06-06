using DevFreela.Core.Entities;
using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.CreateComment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly IProjectRepository _projectRepository;
        public CreateCommentCommandHandler(DevFreelaDbContext dbContext, IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new ProjectComment(request.Content, request.IdUser, request.IdFreelancer);

            await _projectRepository.PostCommentAsync(comment);

            return Unit.Value;
        }
    }
}
