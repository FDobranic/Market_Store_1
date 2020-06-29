using Market_Store.Model;
using System;

namespace Market_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            BronzeCard bronzeCard = new BronzeCard(150);
            double bronzePurchaseValue = 150;

            Console.WriteLine("Bronze card: ");
            Console.WriteLine("Purchase value: ${0}", bronzePurchaseValue);
            Console.WriteLine("Discount rate: {0}%", bronzeCard.getRate());
            Console.WriteLine("Discount: ${0}", bronzeCard.calculateDiscount(bronzePurchaseValue));
            Console.WriteLine("Total: ${0}", bronzeCard.CalculateTotal(bronzePurchaseValue));

            Console.WriteLine();

            SilverCard silverCard = new SilverCard(600);
            double silverPurchaseValue = 850;

            Console.WriteLine("Silver card: ");
            Console.WriteLine("Purchase value: ${0}", silverPurchaseValue);
            Console.WriteLine("Discount rate: {0}%", silverCard.calculateRate());
            Console.WriteLine("Discount: ${0}", silverCard.calculateDiscount(silverPurchaseValue));
            Console.WriteLine("Total: ${0}", silverCard.CalculateTotal(silverPurchaseValue));

            Console.WriteLine();

            GoldCard goldCard = new GoldCard(1500);
            double goldPurchaseValue = 1300;

            Console.WriteLine("Gold card: ");
            Console.WriteLine("Purchase value: ${0}", goldPurchaseValue);
            Console.WriteLine("Discount rate: {0}%", goldCard.calculateRate());
            Console.WriteLine("Discount: ${0}", goldCard.calculateDiscount(goldPurchaseValue));
            Console.WriteLine("Total: ${0}", goldCard.CalculateTotal(goldPurchaseValue));
        }
    }
}
