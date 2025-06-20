﻿using DevFreela.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.Project.GetById
{
    public class GetByIdProjectQuery : IRequest<ProjectDetailsViewModel>
    {
        public GetByIdProjectQuery(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }

    }
}
