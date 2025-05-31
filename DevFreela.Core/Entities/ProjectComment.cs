using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class ProjectComment: BaseEntity
    {
        public ProjectComment(string content, int idUser, int idProject) :base()
        {
            Content = content;
            IdUser = idUser;
            IdProject = idProject;
        }

        public Project Project { get; private set; }
        public string Content { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
        public int IdProject { get; private set; }
        public DateTime CreateAt { get; private set; }
        
    }
}
