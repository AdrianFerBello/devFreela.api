using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Skills.UpdateSkill
{
    public class UpdateSkillCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
