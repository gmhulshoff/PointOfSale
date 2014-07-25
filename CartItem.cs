using System;

namespace PointOfSale
{
    public class CartItem : Pricing
    {
        private int timesScanned = 0;

        public CartItem(Pricing pricing) :
            base(pricing.unitPrice, pricing.volumeCount, pricing.volumePrice) { }

        public void Scan()
        {
            timesScanned++;
        }

        public double CalculateTotal()
        {
            if (volumeCount == 0)
                return unitPrice * timesScanned;
            return volumePrice * (timesScanned / volumeCount) + unitPrice * (timesScanned % volumeCount);
        }
    }
}
