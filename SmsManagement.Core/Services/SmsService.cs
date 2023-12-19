using SmsManagement.Core.Entities;
using SmsManagement.Core.Interfaces;
using SmsManagement.SheredKernel;
using SmsManagement.SheredKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.Core.Services
{
    public class SmsService : ISmsService
    {
        private readonly ApiCaller _apiCaller;
        private readonly SmsLogService _smsLogService;

        public SmsService(ApiCaller apiCaller, SmsLogService smsLogService)
        {
            _apiCaller = apiCaller;
            _smsLogService= smsLogService;
        }

        public async Task SendSmsAsync(Sms sms)
        {
            var smsLog = new SmsLog(0,0,sms.SmsBody,DateTime.Now);

            smsLog = await _smsLogService.AddSmsLog(smsLog);
            sms.Id = smsLog.Id;
            await _apiCaller.PostAsync("/api/basesms/basesendsms",sms);
        }
    }
}
