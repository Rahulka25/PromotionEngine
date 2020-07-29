using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.InitProducts();
            OfferService offerService = new OfferService();
            offerService.InitializeOffers();
            OrderManager orderManager = new OrderManager();
            orderManager.InitOrders();
            Offer offer = new Offer();
            offer.InitOffer();
            offerService.ApplyOffers(offer.Offers, orderManager.Orders, productManager.Products);
            var total = orderManager.CalculateTotalPrice();
        }
    }
}
