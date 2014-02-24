using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics; //For Complex type

namespace Demo_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's calculate some quadratics!!
            int a = 0;
            int b = 0;
            int c = 0;
            double argument = 0;
            double root1 = 0;
            double root2 = 0;

            a = GetInt("First coefficient (a)?");
            b = GetInt("First coefficient (b)?");
            c = GetInt("First coefficient (c)?");

            Console.WriteLine("Equation: {0}x^2 + {1}x + {2} = 0",a,b,c);

            //Determine the argument of the radical 
            argument = Math.Pow(b, 2) - 4*a*c; //Ok to implicitly promote my int args to double

            if (argument > 0)
            {
                root1 = (-b + Math.Sqrt(argument))/(2.0 * a); //OK to use ints, because argument is already a double
                root2 = (-b - Math.Sqrt(argument))/(2.0 *   a);
                Console.WriteLine("Real Roots: {0}, {1}", root1, root2);
            }
            else if (argument == 0)
            {
                root1 = -b / (2 * a);
                Console.WriteLine("Identical Roots: {0", root1);
            }
            else //Less than zero, complex roots
            {
                Complex croot1 = new Complex(-b / (2.0 * a), Math.Sqrt(-argument)/(2.0 * a));
                Complex croot2 = new Complex(-b / (2.0 * a), -Math.Sqrt(-argument) / (2.0 * a));
                Console.WriteLine("Complex Roots: {0}, {1}", croot1, croot2);
            }

            //Show some key values
            for (int i = 0; i < 10; ++i )
                GetKeyInfo();
            GetKey();
        }


        static public int GetInt(string prompt)
        {
            string input = null;
            bool badIn = false;
            int output = 0;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                badIn = int.TryParse(input, out output);
            }
            while (!badIn);
            return output;
        }

        static public void GetKey(string prompt = "")
        {
            if (prompt == "") prompt = "Press any key to continue";
            Console.Write(prompt);
            Console.ReadKey(true);
        }

        static public void GetKeyInfo()
        {
            Console.Write("Press a Key");
            ConsoleKeyInfo cki = Console.ReadKey(true);
            Console.WriteLine("\nYou pressed the {0} key. With modifiers:{1}", cki.Key,cki.Modifiers);
        }


    }
}
