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

namespace SmsManagement.BaseWebApi.Controllers
{
    public class BaseSmsController : ApiController
    {
        private readonly BaseSmsService _baseSmsService;

        //public BaseSmsController(BaseSmsService baseSmsService)
        public BaseSmsController()
        {
            _baseSmsService = new BaseSmsService(new SheredKernel.ApiCaller2("https://localhost:44374"),new SmsLogService(new AppDbContext<SmsLog>()));
        }
        [HttpPost]
        public async Task BaseSendSms(Sms sms)
        {
           await _baseSmsService.BaseSendSmsAsync(sms);
        }
    }
}