using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJALibrary;

namespace Demo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(3,1.0));
            Console.WriteLine(Methods.Add(3, 6));
            Console.WriteLine(Methods.Add(1, 3.0));
            Console.WriteLine(Methods.Add('a'));
            Methods.Pause();
        }
    }
}
