using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Model
{
    abstract class DiscountCards
    {
        public string OwnerInfo { get; set; }
        public double Turnover { get; set; }
        public double DiscountRate { get; set; }

        public double calculateDiscount(double valueOfPurchase)
        {
            return valueOfPurchase * DiscountRate / 100;
        }

        public double CalculateTotal(double purchaseValue)
        {
            double discount = calculateDiscount(purchaseValue);
            return purchaseValue - discount;
        }
    }
}
