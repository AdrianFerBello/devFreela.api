﻿using DevFreela.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.User.GetAll
{
    public class GetAllUserQuery : IRequest<List<UserViewModel>>
    {
    }
}
