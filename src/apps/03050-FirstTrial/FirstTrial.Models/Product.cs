using System.Collections.Generic;

namespace FirstTrial.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Discontinued { get; set; }
        public byte[] Image { get; set; } = default!;
        public string Description { get; set; } = string.Empty;

        private ProductCategory _category = default!;
        public ProductCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (_category != null && _category.Products.Contains(this)) _category.Products.Remove(this);
                _category = value;
                if (_category != null) _category.Products.Add(this);
            }
        }


        private List<OrderDetail> _orderDetails = new List<OrderDetail>();
        public List<OrderDetail> OrderDetails
        {
            get
            {
                return _orderDetails;
            }
        }
    }
}
