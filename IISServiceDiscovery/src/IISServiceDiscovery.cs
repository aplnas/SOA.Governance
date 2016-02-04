using Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace IISServiceDiscovery
{
     public class IISServiceDiscovery : IServiceDiscovery
     {
          static string IISLoadBalancer = ConfigurationManager.AppSettings["LoadBalancer"];
          
          public string Locate(string serviceName)
          {
               throw new NotImplementedException();
          }

          public void SetEnvironmentConfig(Dictionary<string, string> configuration)
          {
               throw new NotImplementedException();
          }
     }
}
