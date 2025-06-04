using DevFreela.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.User.GetById
{
    public class GetByIdUserQuery : IRequest<UserDetailsViewModel>
    {
        public int Id { get; set; }

        public GetByIdUserQuery(int id)
        {
            Id = id;
        }
    }
}
