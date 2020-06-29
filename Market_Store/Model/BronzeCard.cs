using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Market_Store.Model
{
    class BronzeCard : DiscountCards
    {

        public BronzeCard() : base() { }
        public BronzeCard(double Turnover) : base()
        {
            this.Turnover = Turnover;
        }

        private double calculateRate()
        {
            if (Turnover < 100)
            {
                DiscountRate = 0;
                return 0;
            }
            else if (Turnover >= 100 && Turnover <= 300)
            {
                DiscountRate = 1;
                return 1;
            }
            else
            {
                DiscountRate = 2.5;
                return 2.5;
            }
        }

        public double getRate()
        {
            return calculateRate();
        }

    }
}
