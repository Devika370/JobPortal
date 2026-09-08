using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainJobPortal.Helpers
{
     public class MailSettings   //Configuration class for Gmail/SMTP Settings.
    {
        public string UserMail { get; set; } 
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
    }
}
