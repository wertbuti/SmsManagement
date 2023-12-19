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

namespace SmsManagement.WebApi.Controllers
{
    public class SmsLogController : ApiController
    {
        private readonly SmsLogService _smsLogService;

        //public SmsLogController(SmsLogService smsLogService)
        public SmsLogController()
        {
            _smsLogService = new SmsLogService(new AppDbContext<SmsLog>());
        }
        [HttpPost]
        public async Task AddSmsLog(SmsLog smsLog)
        {
          await  _smsLogService.AddSmsLog(smsLog);
        }
    }
}