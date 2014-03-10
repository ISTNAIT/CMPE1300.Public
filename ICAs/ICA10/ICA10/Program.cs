using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICA10
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numGrades = 0;
            double grade = 0;
            double weight = 0;
            double sumNum = 0;
            double sumDen = 0;
            double average = 0;
            bool goAgainP = false;
            
            DisplayTitle();
            do
            {
                numGrades = GetUInt("Please enter the number of grades that you wish to average (max. 10): ", 1, 10);

                for (int i = 1; i <= numGrades; ++i)
                {
                    grade = GetDouble(String.Format("Please enter the value for grade item #{0}: ", i),
                            0, 100, "Grades must be between {0} and {1}");
                    weight = GetDouble(String.Format("Please enter the weight of item #{0}: ", i),
                            1, 50, "Grade item weights must be between {0} and {1}");
                    sumNum += grade * weight;
                    sumDen += weight;
                }

                average = sumNum / sumDen;
                Console.WriteLine("\nYour weighted average for the supplied grades is {0:f2}",average);

                goAgainP = AskYorN("Do you wish to perform another average?");
            }
            while (goAgainP);
            Console.WriteLine("\nThank you for using the Weighted Average Calculator! See Ya!");
           
            PressAnyKey("Press any key to exit...");
        }

        static private double GetDouble(string prompt, double min, double max,
            string errorMsg = "Please enter a number between {0} and {1}, inclusive.")
        {
            string input = null;
            bool validp = false;
            double val;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                validp = double.TryParse(input, out val);
                if (!validp)
                    Console.Error.WriteLine("Invalid input.");
                else if (val < min || val > max)
                    Console.Error.WriteLine(errorMsg, min, max);
            }
            while (!validp || val < min || val > max);

            return val;
        }

        static private uint GetUInt(string prompt, uint min, uint max)
        {
            string input = null;
            bool validp = false;
            uint val;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                validp = uint.TryParse(input,out val);
                if(!validp)
                    Console.Error.WriteLine("Invalid input.");
                else if(val < min || val > max)
                    Console.Error.WriteLine("Please enter a number between {0} and {1}, inclusive.", min, max);
            }
            while(!validp || val < min || val > max);

            return val;
        }

        static private void DisplayTitle(string title = "Welcome to the Weighted Grade Average Calculator!")
        {
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine();
        }

        static private void PressAnyKey(string prompt = "Press any key to continue")
        {
            Console.Write(prompt);
            Console.ReadKey(true);
        }

        static private bool AskYorN(string prompt = "Yes or no")
        {
            string response = null;
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine();
                response = response.ToLower();
                if (response == "yes" || response == "y" || response == "ok" || response == "sure")
                    return true;
                if (response == "no" || response == "n" || response == "nope" || response == "negatory")
                    return false;
            }
            while (true);
        }
    }
}
