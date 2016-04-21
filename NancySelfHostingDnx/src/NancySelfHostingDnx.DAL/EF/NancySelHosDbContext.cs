using Microsoft.Data.Entity;

namespace NancySelfHostingDnx.DAL.EF
{
    public class NancySelHosDbContext : DbContext
    {
         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}