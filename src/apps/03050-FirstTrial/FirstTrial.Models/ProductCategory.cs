using System.Collections.Generic;

namespace FirstTrial.Models
{
    public class ProductCategory
    {
        public long Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int ProductCount
        {
            get
            {
                if (_products == null) return 0;
                return _products.Count;
            }
        }

        private List<Product> _products = new List<Product>();
        public List<Product> Products
        {
            get
            {
                return _products;
            }
        }
    }
}
