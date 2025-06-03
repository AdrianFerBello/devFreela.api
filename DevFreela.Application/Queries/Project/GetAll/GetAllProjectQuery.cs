using DevFreela.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Project.GetAll
{
    public class GetAllProjectQuery : IRequest<List<ProjectViewModel>>
    {
        public string Src { get; set; }

        public GetAllProjectQuery(string src)
        {
            Src = src;
        }
    }
}
