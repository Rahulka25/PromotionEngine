using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    class ProductManager
    {
        private List<Product> products = null;
        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void InitProducts()
        {
            this.products = new List<Product>
            {
                new Product {Name = "A" , Price = 50 },
                new Product {Name = "B" , Price = 30 },
                new Product {Name = "C" , Price = 20 },
                new Product {Name = "D" , Price = 15 }
            };
        }
    }
}
