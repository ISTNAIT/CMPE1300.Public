using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_1
{
    class MyFirstInstructions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world.");
            Console.WriteLine(); //Blank line

            //Pause and wait for user.
            Console.Write("Press Enter to Continue:"); //Just like writeline, but no new line.
            Console.ReadLine();
        }
    }
}
