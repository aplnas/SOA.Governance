using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Contracts.Contracts
{
     interface IServiceDiscoverable
     {
          string ServiceName { get; set; }
     }
}
