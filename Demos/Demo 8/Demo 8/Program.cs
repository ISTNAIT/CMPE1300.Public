using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double dValue = 0; //It's ok to initialize with the int 0.  Normal even.
            int iValue = 0;

            

            for (int i = 0; i < 10000; ++i)
            {
                if (i % 5 == 0) Console.WriteLine(); //New line every time i a multiple of 3
                iValue = rand.Next((int)1e09);
                dValue = iValue / 1.0e6;  //Integer divided by double is a double.
                Console.Write("{0,10:f3}",dValue);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
