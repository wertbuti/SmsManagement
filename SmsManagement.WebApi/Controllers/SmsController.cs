using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SmsManagement.Core.Entities;
using SmsManagement.Core.Interfaces;
using SmsManagement.Core.Services;
using SmsManagement.Infrastructure.Data;
using SmsManagement.SheredKernel;

namespace SmsManagement.WebApi.Controllers
{
    public class SmsController : ApiController
    {
        private readonly SmsService _smsService;

        //public SmsController(SmsService smsService)
        public SmsController()
        {
            _smsService = new SmsService(new ApiCaller("https://localhost:44332"),new SmsLogService(new AppDbContext<SmsLog>()));
        }
        [HttpPost]
        public async Task SendSms(Sms sms)
        {
            await _smsService.SendSmsAsync(sms);
        }
    }
}