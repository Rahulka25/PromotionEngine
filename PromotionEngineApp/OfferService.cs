using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class OfferService
    {

        public void FixedPriceForItems(string productName,int fixedQty,double fixedPrice, List<Product> products , List<Order> orders)
        {
            var product = products.FirstOrDefault(item => item.Name == productName);
            var orderItem = orders.FirstOrDefault(item => item.Name == productName);

            if (product != null && orderItem != null)
            {
                if(orderItem.Quantity >= fixedQty)
                {
                    double totalFixedValue = orderItem.Quantity / fixedQty;
                    var remainingitemCount = orderItem.Quantity - (Math.Truncate(totalFixedValue) * fixedQty);
                    var offerItemCount = (Math.Truncate(totalFixedValue) * fixedQty);
                    orderItem.Price = (remainingitemCount * product.Price) + (Math.Truncate(totalFixedValue) * fixedPrice);
                }
                else
                {
                    orderItem.Price = orderItem.Quantity * product.Price;
                }
                orders.Where(w => w.Name == productName).Select(w => { w.Price = orderItem.Price; return w; });
            }
        }
    }
}
