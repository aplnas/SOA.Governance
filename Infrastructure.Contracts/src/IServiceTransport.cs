using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts
{
     public interface IServiceTransport
     {
          Task<Object> Deliver(string target, string body);
          Task<Object> Get(string target, string body);
     }
}
