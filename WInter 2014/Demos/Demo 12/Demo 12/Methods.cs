using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJALibrary
{
    public class Methods
    {
        static public int Add (int x, int y = 1)
        { return x + y;}
        static public long Add(long x, long y = 1L)
        { return x + y;}
        static public double Add(double x, double y = 1.0)
        { return x + y;}
        static public float Add(float x, float y = 1.0f)
        {  return x + y;}

        static public void Pause(string message = "Press Any Key to Continue")
       {
            Console.Write(message);
            Console.ReadKey();
        }
    }
}
