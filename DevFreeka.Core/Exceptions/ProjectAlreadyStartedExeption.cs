using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedExeption : Exception
    {
        public ProjectAlreadyStartedExeption() : base("Project is Already in Start status")
        {
            
        }
    }
}
