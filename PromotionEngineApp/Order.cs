﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class Order
    {
        public string Name { get;set;}
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool IsOfferApplicable { get; set; }
    }
}
