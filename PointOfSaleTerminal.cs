using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        Dictionary<char, Pricing> pricings;
        Dictionary<char, int> cartItems = new Dictionary<char, int>();

        internal void SetPricing(Dictionary<char, Pricing> pricings)
        {
            this.pricings = pricings;
        }

        public double CalculateTotal()
        {
            return cartItems.Sum(p => pricings[p.Key].CalculatePrice(p.Value));
        }

        public void Scan(string code)
        {
            foreach (var itemCode in code)
                Scan(itemCode);
        }

        private void Scan(char itemCode)
        {
            int timesScanned;
            if (!cartItems.TryGetValue(itemCode, out timesScanned))
                cartItems.Add(itemCode, 0);
            cartItems[itemCode]++;
        }
    }
}
