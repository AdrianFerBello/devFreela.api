using DevFreela.Application.ViewModels;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.User.GetAll
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<UserViewModel>>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetAllUserQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserViewModel>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var users = _dbContext.Users;
            var listUsersViewModel = users
                .Select(x => new UserViewModel(x.Id, x.Name, x.Email))
                .ToList();
            return listUsersViewModel;
        }
    }
    
}
