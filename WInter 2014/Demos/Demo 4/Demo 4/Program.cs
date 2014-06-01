using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string stooge = "";
            string colour = "";

            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("Who is your favourite stooge? ");
            stooge = Console.ReadLine();

            Console.Write("What is your favourite colour? ");
            colour = Console.ReadLine();

            Console.WriteLine("\n{0} is my new friend.  He (or she) is a fan of {1}.  " + 
            "For some reason, they also like the colour {2}, which I think is wretched.", 
            name, stooge, colour);

            Console.Write("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
