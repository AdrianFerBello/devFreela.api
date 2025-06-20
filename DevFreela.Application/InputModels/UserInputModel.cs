using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class UserInputModel
    {
        public UserInputModel(string name, string email, DateTime birthDate, DateTime createAt, string password, string role)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreateAt = createAt;
            Password = password;
            Role = role;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateAt { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
