//namespace FirstTrial.ConsoleUi.Models
//{
//    public class Order
//    {
//        public long Id { get; set; }
//        public DateTime OrderDate { get; set; }
//        public DateTime? ShippedDate { get; set; }
//        public string ShipName { get; set; } = string.Empty;
//        public Address ShipAddress { get; set; } = default!;
//        public decimal ShippingFee { get; set; }
//        public decimal Taxes { get; set; }
//        public string PaymentType { get; set; } = string.Empty;
//        public DateTime? PaidDate { get; set; }
//        public string Notes { get; set; } = string.Empty;
//        public decimal TaxRate { get; set; }
//        public OrderStatus Status { get; set; }

//        private Customer _customer = default!;
//        public Customer Customer
//        {
//            get
//            {
//                return _customer;
//            }
//            set
//            {
//                if (_customer != null && _customer.Orders.Contains(this)) _customer.Orders.Remove(this);
//                _customer = value;
//                if (_customer != null) _customer.Orders.Add(this);
//            }
//        }


//        private List<OrderDetail> _orderDetails = new List<OrderDetail>();
//        public List<OrderDetail> OrderDetails
//        {
//            get
//            {
//                return _orderDetails;
//            }
//        }
//    }
//}
