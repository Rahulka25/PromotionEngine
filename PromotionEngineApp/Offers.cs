using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    class Offer
    {
        public Offer()
        {
            this.Offers = new List<string>();
        }
        public List<string> Offers { get; set; }

        public void InitOffer()
        {
            this.Offers = new List<string> { "FixedPriceForAItems", "FixedPriceForBItems" };
        }
    }
}
