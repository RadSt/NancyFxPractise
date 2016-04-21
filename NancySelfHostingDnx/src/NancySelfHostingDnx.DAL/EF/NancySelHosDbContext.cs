using Microsoft.Data.Entity;
using NancySelfHostingDnx.DAL.Models;

namespace NancySelfHostingDnx.DAL.EF
{
    public class NancySelHosDbContext : DbContext
    {
         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<UserProfile>  UserProfiles { get; set; }
    }
}