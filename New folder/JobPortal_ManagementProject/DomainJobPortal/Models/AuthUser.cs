using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainJobPortal.Enums;

namespace DomainJobPortal.Models
{
    public class AuthUser
    {
        public int AuthUserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public EmailVerificationStatus  Status { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt {  get; set; }
    }
}
