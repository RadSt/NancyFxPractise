
using Microsoft.Data.Entity;
using NancySelfHosting.DAL.Entities;

namespace NancySelfHosting.DAL.EF
{
    public class MobileContext : DbContext
    {
         public DbSet<Phone> Phones { get; set; } 
         public DbSet<Order> Orders { get; set; }
    }
}