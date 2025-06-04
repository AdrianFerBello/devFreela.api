using DevFreela.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Skill.GetById
{
    public class GetByIdSkillQuery : IRequest<SkillDetailsViewModel>
    {
        public int Id { get; private set; }

        public GetByIdSkillQuery(int id)
        {
            Id = id;
        }
    }
}
