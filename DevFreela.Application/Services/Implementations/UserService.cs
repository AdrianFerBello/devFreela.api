using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(UserInputModel inputModel)
        {
            var user = new User (inputModel.Name, inputModel.Email, inputModel.BirthDate);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return user.Id;
        }

        public List<UserViewModel> GetAll()
        {
            var users = _dbContext.Users;

            var listUserViewModel = users
                .Select(x => new UserViewModel(x.Id, x.Name, x.Email))
                .ToList();

            return listUserViewModel;
        }

        public UserDetailsViewModel GetById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);

            var userDetails = new UserDetailsViewModel(
                user.Id,
                user.Name,
                user.Email,
                user.BirthDate,
                user.CreateAt);

            return userDetails;
        }

        public void LoginModel(LoginInputModel inputModel)
        {
            //implementada na parte de autenticação e autorização com JWT!
            throw new NotImplementedException();
        }
    }
}
