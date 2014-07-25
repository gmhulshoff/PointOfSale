using System;

namespace PointOfSale
{
    public class Pricing
    {
        internal double unitPrice;
        internal int volumeCount;
        internal double volumePrice;

        public Pricing(double unitPrice, int volumeCount = 0, double volumePrice = 0.0)
        {
            this.unitPrice = unitPrice;
            this.volumeCount = volumeCount;
            this.volumePrice = volumePrice;
        }
    }
}
