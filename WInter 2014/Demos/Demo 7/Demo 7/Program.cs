using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string buffer = null; //Temporary input from user
            string output = null; //Message holder
            uint age = 0; //The user's age
            uint number = 0; //The user's favorite number
            string stooge = null; //The user's favorite stooge.

            do
            {
                Console.Write("How old are you?");
                buffer = Console.ReadLine();
            }
            while (!uint.TryParse(buffer, out age));

            if (age < 6)
                Console.WriteLine("You really shouldn't be on the computer.");
            else if (age < 15)
                Console.WriteLine("Shouldn't you be texting?");
            else if (age < 25)
                Console.WriteLine("You seem to have confused me with a Playstation.");
            else if (age < 45)
            {
                Console.WriteLine("Your mortgage payment is due.");
                Console.WriteLine("Shouldn't you be working?");
            }
            else if (age < 55)
                Console.WriteLine("Press the square things on the pad in front of you.  Pretty lights!");
            else if (age < 75)
                Console.WriteLine("Get off my lawn!");
            else
                Console.WriteLine("Get the exorcist!  The demon machine is beeping again!");


            do
            {
                Console.Write("What's your favorite number between 1 and 10?");
                buffer = Console.ReadLine();
            }
            while (!uint.TryParse(buffer, out number) || number > 10 || number <= 0); //Remember that && is lazy

            switch (number)
            {
                case 1:
                    output = "The loneliest number.";
                    break;
                case 2:
                case 3:
                case 5:
                case 7: output = "Prime!"; break;
                case 8:
                case 9: output = "Cube!"; break;
                case 4: output = "Square!"; break;
                default: output = "6 is the boringest number."; break;
            }
            Console.WriteLine(output);


            Console.Write("Who is your favorite stooge?");
            stooge = Console.ReadLine();
            switch (stooge.ToUpper())
            {
                case "LARRY" : case "MOE" : case "CURLY" :
                    Console.WriteLine("An excellent choice.");
                    break;
                case "CURLY JOE" :
                    Console.WriteLine("A poor substitute.");
                    break;
                default:
                    Console.WriteLine("That's not a stooge.  But you are.");
                    break;

            }

            Console.Write("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}
