using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInput = "";
            int iAge = 0;
            int iEyes = 0;
            int iStudentId = 0;
            bool bResult = false;

            Console.Write("How old are you? ");
            sInput = Console.ReadLine();
            bResult = int.TryParse(sInput, out iAge);

            //If statement
            if (bResult) //True means successfully parsed
                Console.WriteLine("You are {0} years old.", iAge);
            else
                Console.WriteLine("You're not particularly good at following instructions, huh?");
            //End of if statement

            //Standard post-test loop.
            do
            {
                Console.Write("Please enter your student ID:");
                sInput = Console.ReadLine();
                bResult = int.TryParse(sInput, out iStudentId);
            }
            while (!bResult); //As long as bResult is false (!bResult is true), keep looping back.

            Console.WriteLine("Your student id is " + iStudentId);

            //Short, fancy version (do not do this yet!  Just for illustration)

            do
                Console.WriteLine("How many eyes do you have?");
            while (!int.TryParse(Console.ReadLine(), out iEyes));


            Console.Write("\nPress any key to continue:");
            Console.ReadKey();

        }
    }
}
