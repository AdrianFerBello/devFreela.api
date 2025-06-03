using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.StartProject
{
    public class StartProjectCommand : IRequest<Unit>
    {
        public int Id { get; private set; }
        public StartProjectCommand(int id)
        {
            Id = id;
        }
    }
}
