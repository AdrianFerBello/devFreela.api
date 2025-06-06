using DevFreela.Core.Repository;
using DevFreela.Infraestructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(DevFreelaDbContext dbContext, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new DevFreela.Core.Entities.User(request.Name, request.Email, request.BirthDate);

            _userRepository.CreateAsync(user);

            return user.Id;

        }
    }
}
