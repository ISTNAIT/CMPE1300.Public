using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some variables

            int i = -3;
            uint u = 42;
            bool b = true;
            char c = 'a';
            string s = "foo";
            double d = 2.71828182845904523536028747135266249775724709369995;

            Console.WriteLine("i is equal to " + i);
            Console.WriteLine("u is equal to " + u);
            Console.WriteLine("b is equal to " + b);
            Console.WriteLine("c is equal to '" + c + "'");
            Console.WriteLine("s is equal to \"" + s + @"""");
            Console.WriteLine("d is equal to " + d);

            Console.WriteLine("The sum of i, u and d is " + (i + u + d));

            Console.Write
                        ("Press Enter to Continue:");
            Console.ReadLine();

        }
    }
}
