using SmsManagement.Core.Entities;
using SmsManagement.Core.Interfaces;
using SmsManagement.Infrastructure.Data;
using SmsManagement.SheredKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.Core.Services
{
    public class SmsLogService : ISmsLogService
    {
        private readonly AppDbContext<SmsLog> _appDbContext;

        public SmsLogService(AppDbContext<SmsLog> appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<SmsLog> AddSmsLog(SmsLog smsLog)
        {
            try
            {
                //return await _appDbContext.AddAsync(smsLog);
                return await _appDbContext.AddAsync(smsLog);
            }
            catch (Exception ex)
            {
                SmsLog s=new SmsLog(1,1,"",DateTime.Now);
                return s;
            }
        }
    }
}
