using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class SkillDetailsViewModel
    {
        public SkillDetailsViewModel(int id, string description, DateTime createAt)
        {
            Id = id;
            Description = description;
            CreateAt = createAt;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}
