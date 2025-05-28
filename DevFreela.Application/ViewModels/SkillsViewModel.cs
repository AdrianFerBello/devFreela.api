using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class SkillsViewModel
    {
        public SkillsViewModel(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string  Description { get; private set; }

    }
}
