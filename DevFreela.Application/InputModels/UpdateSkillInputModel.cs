using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class UpdateSkillInputModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public UpdateSkillInputModel(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
