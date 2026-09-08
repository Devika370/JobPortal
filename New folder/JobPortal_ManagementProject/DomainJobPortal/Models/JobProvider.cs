using DomainJobPortal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainJobPortal.Models
{
    public class JobProvider
    {

        public int JobProviderId { get; set; }
        public int AuthUserId { get; set; } //FK
        public int CompanyId { get; set; } //FK
        public ProviderStatus providerStatus { get; set; } //Provider Approval Status
        public DateTime? ApprovedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public AuthUser AuthUser { get; set; }//Navigation
        public Company Company { get; set; }//Navigation
    }
}
