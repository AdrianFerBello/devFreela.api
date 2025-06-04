using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.User.GetById
{
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, UserDetailsViewModel>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetByIdUserQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserDetailsViewModel> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == request.Id);

            var viewModel = new UserDetailsViewModel(
                user.Id,
                user.Name,
                user.Email,
                user.BirthDate,
                user.CreateAt);

            return viewModel;
        }
    }
}
