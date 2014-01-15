using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
@"Windows IP Configuration

She said ""You're really boring.""

Ethernet adapter Local Area Connection:

   Connection-specific DNS Suffix  . : nait.ca
   Link-local IPv6 Address . . . . . : fe80::7de9:5aac:1dad:7e2a%11
   IPv4 Address. . . . . . . . . . . : 10.129.254.110
   Subnet Mask . . . . . . . . . . . : 255.255.254.0
   Default Gateway . . . . . . . . . : 10.129.255.254

Tunnel adapter Local Area Connection* 9:

   Media State . . . . . . . . . . . : Media disconnected
   Connection-specific DNS Suffix  . :

Tunnel adapter isatap.nait.ca:

   Media State . . . . . . . . . . . : Media disconnected
   Connection-specific DNS Suffix  . : nait.ca"
   );
            Console.WriteLine("\n\nSome blank lines\n\n");
            Console.Write("\"It\'s a windy day\"\t\tYes, yes it is\nIs it murder if they're my own clones?");
            Console.WriteLine(" This is on the same line.");
            Console.Write("Aaaand this is on a different one.");

            Console.Write("Press Enter to Continue:");
            Console.ReadLine();
        }
    }
}
