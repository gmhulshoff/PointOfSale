using System;

namespace PointOfSale
{
    public class Pricing
    {
        private double unitPrice;
        private int volumeCount;
        private double volumePrice;

        public Pricing(double unitPrice, int volumeCount = 0, double volumePrice = 0.0)
        {
            this.unitPrice = unitPrice;
            this.volumeCount = volumeCount;
            this.volumePrice = volumePrice;
        }

        public double CalculatePrice(int timesScanned)
        {
            if (volumeCount == 0)
                return unitPrice * timesScanned;
            return volumePrice * (timesScanned / volumeCount) + unitPrice * (timesScanned % volumeCount);
        }
    }
}
