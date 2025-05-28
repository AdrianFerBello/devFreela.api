using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(int id, string name, string email, DateTime birthdate, DateTime createAt)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthdate;
            CreateAt = createAt;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}
