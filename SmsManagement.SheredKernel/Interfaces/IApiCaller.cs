﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.SheredKernel.Interfaces
{
    public interface IApiCaller
    {
         Task PostAsync(string requestUrl, object obj);
    }
}
