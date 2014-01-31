using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long pennies = 0;
            int dollars = 0;
            int quarters = 0;
            int dimes = 0;
            int nickles = 0;
            bool goodInput = false; //Did I get a positive number?
            string input = null;
           
            Console.WriteLine("Welcome to the Bank of AJ -- Keeper of Pennies for the Masses");

            do
            {
                Console.Write("\nHow many pennies do you have? ");
                input = Console.ReadLine();
                goodInput = long.TryParse(input, out pennies);
                if (goodInput)
                    if (pennies < 0)
                        goodInput = false;
            }
            while (!goodInput);

            dollars = (int) (pennies / 100L);
            pennies %= 100;
            quarters = (int)(pennies / 25L);
            pennies %= 25;
            dimes = (int)(pennies / 10L);
            pennies %= 10;
            nickles = (int)(pennies / 5L);
            pennies %= 5;

            Console.WriteLine("\nYou have {0} dollars, {1} quarters, {2} dimes, {3} nickels and {4} pennies!",
                dollars,quarters,dimes,nickles,pennies);

            Console.WriteLine("\nPress any key to continue:");
            Console.ReadKey();

        }
    }
}
