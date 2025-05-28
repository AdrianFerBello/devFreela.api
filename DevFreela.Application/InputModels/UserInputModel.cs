using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class UserInputModel
    {
        public UserInputModel(string name, string email, DateTime birthDate, DateTime createAt)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreateAt = createAt;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
