using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveSalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            //sales tax Calculator
            double itemPrice;
            double total;
            const double TAX_RATE = 0.06;
            string itemPriceString;

            Console.Write("Enter the Price of the an item >>");
            itemStringPrice = Console.ReadLine();

            itemPrice = Convert.ToDouble(itemPriceString);
            total = itemPrice * TAX_RATE;

            Console.WriteLine("With a tax rate of {0}, a {1} item"+
                "cost {2} more,", TAX_RATE, itemPrice.ToString("c"), total.ToString("C"; 
        }
    }
}

