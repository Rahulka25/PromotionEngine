using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class OfferService
    {
        public OfferService()
        {
            this.OfferMap = new Dictionary<string, Delegate>();
        }

        public void InitializeOffers()
        {
            this.OfferMap.Add("FixedPriceForAItems",new Func<string, int, double, List<Product>, List<Order>,bool>(FixedPriceForItems));
            this.OfferMap.Add("FixedPriceForBItems", new Func<string, int, double, List<Product>, List<Order>, bool>(FixedPriceForItems));

        }

        public new Dictionary<string, Delegate> OfferMap { get; set; }


        public bool FixedPriceForItems(string productName,int fixedQty,double fixedPrice, List<Product> products , List<Order> orders)
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
                return true;
            }
            return false;
        }

        public void ApplyOffers(List<string> offers, List<Order> orders, List<Product> products)
        {
            foreach(var offerName in offers)
            {
                if (this.OfferMap.ContainsKey(offerName))
                {
                    if (offerName == "FixedPriceForAItems")
                    {
                        OfferMap[offerName].DynamicInvoke("A", 2, 130, products, orders);
                    }
                    if (offerName == "FixedPriceForBItems")
                    {
                        OfferMap[offerName].DynamicInvoke("B", 2, 130, products, orders);
                    }
                }
            }
        }

    }
}
