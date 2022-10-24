using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi
{
   public interface IEmailManager
    {
        void Send(string email);
    }
}
