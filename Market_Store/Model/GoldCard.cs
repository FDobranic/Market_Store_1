using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store.Model
{
    class GoldCard : DiscountCards
    {
        public GoldCard() : base() { }

        public GoldCard(double Turnover) : base()
        {
            this.Turnover = Turnover;
        }

        public double calculateRate()
        {
            if(Turnover >= 800)
            {
                DiscountRate = 10;
                return DiscountRate;
            }
            else if (Turnover >= 100)
            {
                DiscountRate = (Turnover + 200) / 100;
                return DiscountRate;
            }
            else
            {
                DiscountRate = 2;
                return DiscountRate;
            }
        }

    }
}
