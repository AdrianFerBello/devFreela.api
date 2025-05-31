using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User: BaseEntity
    {
        public User()
        {
            
        }
        public User(string name, string email, DateTime birthDate): base()
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreateAt = DateTime.Now;
            IsActive = true;

            Skills = [];
            OwnedProjects = [];
            FreelancerProject = [];
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreateAt { get; private set; }
        public bool IsActive { get; private set; }


        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelancerProject { get; private set; }
        public List<ProjectComment> Comments { get; private set; }


    }
}
