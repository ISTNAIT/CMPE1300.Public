using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//You need to add these, and maybe some references
using System.Threading;
using System.Drawing;
using GDIDrawer;

namespace Demo_10
{
    class Program
    {
        static CDrawer Draw = new CDrawer();

        static void Main(string[] args)
        {
            //X co-ordinates
            for (int x = 0; x < 799; ++x)
            {
                //Draw a square at x,x
                Draw.AddRectangle(x, x, 50, 50);
                //Put a circle inside
                Draw.AddCenteredEllipse(x, x, 50, 50,Color.Black);
                Thread.Sleep(10);
                //Now erase it
                Draw.AddRectangle(x, x, 50, 50,Color.Black);
                
            }

            Draw.AddCenteredEllipse(100, 100, 100, 100);

            Console.Write("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
