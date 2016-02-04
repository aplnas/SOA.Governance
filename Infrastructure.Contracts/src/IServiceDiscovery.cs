using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts
{
    public interface IServiceDiscovery
     {
          string Locate(string serviceName);
          void SetEnvironmentConfig(Dictionary<string, string> configuration);
     }
}
