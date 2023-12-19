using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.Core.Entities
{
    public class SmsLog
    {
        public SmsLog(long id, long pid, string smsBody, DateTime registerDate)
        {
            Id = id;
            Pid = pid;
            SmsBody = smsBody;
            RegisterDate = registerDate;
        }

        public long Id { get; set; }
        public long Pid { get; set; }
        public string SmsBody { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
