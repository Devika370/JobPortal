using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DomainJobPortal.Models
{
    public class JobPortalApplicationDBContext : DbContext
    {
        public JobPortalApplicationDBContext(DbContextOptions<JobPortalApplicationDBContext> options)
            :base(options) 
        { 

        }

        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobProvider> JobProviders { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }


    }
}
