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
                new Order{ Name = "A" , Quantity = 5 , Price = 0 },
                new Order{ Name = "B" , Quantity = 4 , Price = 0 },
                new Order{ Name = "c" , Quantity = 1 , Price = 0 },
                new Order{ Name = "D" , Quantity = 1 , Price = 0 },
            };
        }

    }
}
