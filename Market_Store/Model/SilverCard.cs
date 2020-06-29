using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Model
{
    class SilverCard : DiscountCards
    {
        public SilverCard() : base() { }
        public SilverCard(double Turnover) : base()
        {
            this.Turnover = Turnover;
        }

        public double calculateRate()
        {
            if (Turnover > 300)
            {
                DiscountRate = 3.5;
                return DiscountRate;
            }
            DiscountRate = 2;
            return DiscountRate;
        }
    }
}
