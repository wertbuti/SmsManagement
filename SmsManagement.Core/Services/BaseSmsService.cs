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
    public class BaseSmsService : IBaseSmsService
    {
        private readonly ApiCaller2 _apiCaller2;
        private readonly SmsLogService _smsLogService;

        public BaseSmsService(ApiCaller2 apiCaller2, SmsLogService smsLogService)
        {
            _apiCaller2 = apiCaller2;
            _smsLogService = smsLogService;
        }

        public async Task BaseSendSmsAsync(Sms sms)
        {
            //کد ارسال اس ام اس اینجا نوشته شود
            var smsLog = new SmsLog(0,sms.Id, sms.SmsBody, DateTime.Now);

           await _apiCaller2.PostAsync("/api/smsLog/addsmslog", smsLog);
        }
    }
}
