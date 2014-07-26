using System;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        private Dictionary<char, int> scannedProducts = new Dictionary<char, int>();
        private Dictionary<char, Pricing> pricings;

        public void SetPricing(Dictionary<char, Pricing> pricings)
        {
            this.pricings = pricings;
        }

        public double CalculateTotal()
        {
            return scannedProducts.Sum(p => pricings[p.Key].CalculatePrice(p.Value));
        }

        public void Scan(string code)
        {
            foreach (var productCode in code)
                Scan(productCode);
        }

        private void Scan(char itemCode)
        {
            int timesScanned;
            if (!scannedProducts.TryGetValue(itemCode, out timesScanned))
                scannedProducts.Add(itemCode, 0);
            scannedProducts[itemCode]++;
        }
    }
}
