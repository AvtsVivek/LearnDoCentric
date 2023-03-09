using System.Collections.Generic;

namespace FirstTrial.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string BusinessPhone { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;
        public string MobilePhone { get; set; } = string.Empty;
        public string FaxNumber { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;

        private List<Order> _orders = new List<Order>();
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
        }
    }
}
