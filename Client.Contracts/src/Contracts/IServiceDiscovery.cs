﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Contracts
{
    public interface IServiceLocator
     {
          string Locate(string serviceName);
          void SetEnvironmentConfig(Dictionary<string, string> configuration);
     }
}
