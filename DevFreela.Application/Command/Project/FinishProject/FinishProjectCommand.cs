﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Command.Project.FinishProject
{
    public class FinishProjectCommand : IRequest<Unit>
    {
        public int Id { get; private set; }

        public FinishProjectCommand(int id)
        {
            Id = id;
        }
    }
}
