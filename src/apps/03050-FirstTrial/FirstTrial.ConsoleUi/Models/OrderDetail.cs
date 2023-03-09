//namespace FirstTrial.ConsoleUi.Models
//{
//    public class OrderDetail
//    {
//        public long Id { get; set; }
//        public decimal Quantity { get; set; }
//        public decimal UnitPrice { get; set; }
//        public double Discount { get; set; }
//        public DateTime DateAllocated { get; set; }
//        public decimal TotalPrice
//        {
//            get
//            {
//                return UnitPrice * Quantity - UnitPrice * Quantity * (decimal)Discount;
//            }
//        }


//        private Order _order = default!;
//        public Order Order
//        {
//            get
//            {
//                return _order;
//            }
//            set
//            {
//                if (_order != null && _order.OrderDetails.Contains(this)) _order.OrderDetails.Remove(this);
//                _order = value;
//                if (_order != null) _order.OrderDetails.Add(this);
//            }
//        }


//        private Product _product = default!;
//        public Product Product
//        {
//            get
//            {
//                return _product;
//            }
//            set
//            {
//                if (_product != null && _product.OrderDetails.Contains(this)) _product.OrderDetails.Remove(this);
//                _product = value;
//                if (_product != null) _product.OrderDetails.Add(this);
//            }
//        }
//    }
//}
