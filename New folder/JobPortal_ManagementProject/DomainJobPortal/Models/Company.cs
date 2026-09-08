using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomainJobPortal.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? Website {  get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int LocationId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Location Locations { get; set; } //Navigation Property
        public ICollection<JobProvider> JobProviders { get; set; }
    }
}
