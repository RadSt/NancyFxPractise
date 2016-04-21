using System.Collections.Generic;

namespace NancySelfHosting.DAL.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; } 
    }
}
