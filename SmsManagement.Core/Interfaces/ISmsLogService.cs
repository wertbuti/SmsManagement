﻿using SmsManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.Core.Interfaces
{
    public interface ISmsLogService
    {
         Task<SmsLog> AddSmsLog(SmsLog smsLog);
    }
}
