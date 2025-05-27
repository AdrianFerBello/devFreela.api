using DevFreela.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idCliente, int idFreelancer, decimal totalCost) : base()
        {
            Title = title;
            Description = description;
            IdCliente = idCliente;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreateAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = [];
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdCliente { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime? StartAt { get; private set; }
        public DateTime? FinishAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }


        public List<ProjectComment> Comments { get; private set; }

    }
}
