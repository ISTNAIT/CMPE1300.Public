using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_15
{
    class Program
    {
        static void Main(string[] args)
        {
           // int i = null;  //Not permitted, because ints can't be null
            int i = 42; //i is associated with a specific area of memory
            i = 77; //Modify the contents of that variable.
            //i = null;  //Still not allowed
            string s = null; //This is OK because s is just a handle on to something.
            s = "Hello";  //S points/refers to/ references an immutable set of locations with "Hello"
            s = "There"; //s now points to a DIFFERENT location in memory

            Console.WriteLine(s + i); //Output to fool optimizer
            Console.WriteLine(Capitalize(Shuffle("Hello","There", "Joe", "Was", "Here")));

            s = @" Four score and seven years ago our fathers brought forth on this continent, a new nation, 
conceived in Liberty, and dedicated to the proposition that all men are created equal.

Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived 
and so dedicated, can long endure. We are met on a great battle-field of that war. We have come to 
dedicate a portion of that field, as a final resting place for those who here gave their lives that 
that nation might live. It is altogether fitting and proper that we should do this.

But, in a larger sense, we can not dedicate -- we can not consecrate -- we can not hallow -- 
this ground. The brave men, living and dead, who struggled here, have consecrated it, far above our 
poor power to add or detract. The world will little note, nor long remember what we say here, but 
it can never forget what they did here. It is for us the living, rather, to be dedicated here to 
the unfinished work which they who fought here have thus far so nobly advanced. It is rather 
for us to be here dedicated to the great task remaining before us -- that from these honored 
dead we take increased devotion to that cause for which they gave the last full measure of 
devotion -- that we here highly resolve that these dead shall not have died in vain -- that this 
nation, under God, shall have a new birth of freedom -- and that government of the people, by the 
people, for the people, shall not perish from the earth.";
            foreach (string z in WordSplitter(s))
                Console.WriteLine(Capitalize(z));
            Console.Read();
        }

        static public string Shuffle(params string[] sParams)
        {
            string returnVal = "";
            StringBuilder sb = new StringBuilder();
            //Make sure I got at least on string
            if (sParams.Length < 1) return returnVal;

            //Get the minimum length of any of the strings
            uint minLength = uint.MaxValue;
            foreach (string s in sParams)
                if (s.Length < minLength) minLength = (uint)s.Length;

            for (int i = 0; i < minLength; ++i)
                foreach (string s in sParams)
                    //NB:  This is absurdly inefficient!! Every time I add a char, I 
                    //Recreate a new string.
                    returnVal += s[i]; //Add the iTh character in that string to my return value

                    //properly speaking, we really should use a StringBuilder for this sort of thing:
                    //sb.Append(s[i]);

            //returnVal = sb.ToString();

            return returnVal;
        }

        public static string Capitalize(string s)
        {
            char[] ca = s.ToCharArray();
            //Not allowed to use a foreach to modify elements
            //foreach (char c in ca)
                //c = char.ToUpper(c);
            for (int i = 0; i < ca.Length; ++i)
                ca[i] = char.ToUpper(ca[i]);

            return new string(ca);
        }

        public static string[] WordSplitter(string s)
        {
            string delims = " ,.!\t\r\n?\";:()-";
            return s.Split(delims.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
        }
 
    }
}
