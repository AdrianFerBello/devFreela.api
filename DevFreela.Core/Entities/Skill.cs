﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string description):base()
        {
            Description = description;
            CreateAt = DateTime.Now;
        }

        public string Description { get; private set; }
        public DateTime CreateAt { get; private set; }

        //metodos
        public void Update(string description)
        {
            Description = description;
        }
    }
}
