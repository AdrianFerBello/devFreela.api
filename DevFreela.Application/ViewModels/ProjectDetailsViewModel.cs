using DevFreela.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, decimal totalCost, DateTime createAt, ProjectStatusEnum status)
        {
            Id = id;
            Title = title;
            TotalCost = totalCost;
            CreateAt = createAt;
            Status = status;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreateAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
    }
}
