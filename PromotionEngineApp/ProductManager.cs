using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    class ProductManager
    {
        public List<Product> Products { get; set; }
        public ProductManager()
        {
            this.Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public void InitProducts()
        {
            this.Products = new List<Product>
            {
                new Product {Name = "A" , Price = 50 },
                new Product {Name = "B" , Price = 30 },
                new Product {Name = "C" , Price = 20 },
                new Product {Name = "D" , Price = 15 }
            };
        }
    }
}
