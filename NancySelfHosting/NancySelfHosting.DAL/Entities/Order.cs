using System;

namespace NancySelfHosting.DAL.Entities
{
    public class Order
    {
        public string OrderId { get; set; }
        public decimal Sum { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
        public DateTime Date { get; set; }
    }
}