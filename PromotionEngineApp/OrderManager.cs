using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class OrderManager
    {
        public OrderManager()
        {

        }

        public List<Order> Orders { get; set; }

        public void InitOrders()
        {
            this.Orders = new List<Order>
            {
                new Order{ Name = "A" , Quantity = 5 , Price = 0 , IsOfferApplicable = false},
                new Order{ Name = "B" , Quantity = 4 , Price = 0 , IsOfferApplicable = false},
                new Order{ Name = "c" , Quantity = 1 , Price = 0 , IsOfferApplicable = false},
                new Order{ Name = "D" , Quantity = 1 , Price = 0 , IsOfferApplicable = false},
            };
        }

        // calculates the total price
        public double CalculateTotalPrice(List<Product> products)
        {
            double total = 0;
            foreach(Order order in Orders)
            {
                if (order.IsOfferApplicable)
                {
                    total = total + order.Price;
                } else
                {
                    total = total + (products.First(item => item.Name == order.Name).Price * order.Quantity);
                }
            }
            return total;
        }

    }
}
