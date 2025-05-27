using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infraestructure.Persistence
{
    public class DbContext
    {
        public DbContext(List<Project> projects, List<User> users, List<Skill> skills)
        {
            Projects = new List<Project>
            {
                new Project("Titulo projeto .NET 1", "Descrição projeto 1", 1, 1, 1000),
                new Project("Titulo projeto .NET 2", "Descrição projeto 2", 1, 1, 2000),
                new Project("Titulo projeto .NET 3", "Descrição projeto 3", 1, 1, 3000)
            };
            Users = new List<User>
            {
                new User("Robert C Marks", "RobertMarks@hotmail.com", new DateTime(1990, 2, 16)),
                new User("Magnus Carlsen", "MagnusCarlsen@hotmail.com", new DateTime(1975, 5, 26)),
                new User("Ronaldinho Gáucho", "RonaldinhoGaucho@hotmail.com", new DateTime(1986, 3, 14))
            };

            Skills = new List<Skill>
            {
                new Skill("C#"),
                new Skill("Python"),
                new Skill("JavaScript")

            };  
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> Comments { get; set; }
    }
}
