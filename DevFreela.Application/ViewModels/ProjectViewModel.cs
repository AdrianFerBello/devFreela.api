using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime creatAt)
        {
            Id = id;
            Title = title;
            CreatAt = creatAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatAt { get; private set; }
    }
}
