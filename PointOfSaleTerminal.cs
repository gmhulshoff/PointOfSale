using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        Dictionary<char, CartItem> cartItems = new Dictionary<char, CartItem>();

        internal void SetPricing(Dictionary<char, Pricing> pricings)
        {
            foreach (var pricing in pricings)
                cartItems.Add(pricing.Key, new CartItem(pricing.Value));
        }

        public double CalculateTotal()
        {
            return cartItems.Values.Sum(p => p.CalculateTotal());
        }

        public void Scan(string code)
        {
            foreach (var itemCode in code)
                cartItems[itemCode].Scan();
        }
    }
}
