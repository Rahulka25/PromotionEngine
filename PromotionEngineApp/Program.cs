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
            productManager.InitProducts(); // initializing the product list can be made dynamic
            OfferService offerService = new OfferService();
            offerService.InitializeOffers(); // initializing the offers can be made dynamic
            OrderManager orderManager = new OrderManager();
            orderManager.InitOrders(); // initializing offers , can be done dynamic
            Offer offer = new Offer();
            offer.InitOffer(); // initializing offers . can be modified for dynamic offers
            offerService.ApplyOffers(offer.Offers, orderManager.Orders, productManager.Products); // applying available offers
            var total = orderManager.CalculateTotalPrice(); // calculating total bill
        }
    }
}
