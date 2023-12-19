using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagement.Core.Entities
{
    public class Sms
    {
        public Sms()
        {
            
        }
        public Sms(long id, string smsBody)
        {
            Id = id;
            SmsBody = smsBody;
        }

        public long Id { get; set; }
        public string SmsBody { get; set; }
    }
}
