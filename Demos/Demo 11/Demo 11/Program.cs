using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using GDIDrawer;

namespace Demo_11
{
    class Program
    {
        static CDrawer Drawer = new CDrawer();

        static void Main(string[] args)
        {
            Drawer.Scale = 20;
            uint speed = 1; //Frames per second

            for (int i = 1; i < 600/Drawer.Scale; ++i)
            {
                Thread.Sleep(1000/(int)speed);
                MoveBrick(i - 1, i - 1, i, i, Color.DodgerBlue);
            }

        }

        static private void MoveBrick(int xOld, int yOld, int xNew, int yNew, Color color)
        {
            //Erase brick at old, draw a brick of color color at new
            Drawer.AddRectangle(xOld, yOld, 1, 1, Color.Black);
            Drawer.AddRectangle(xNew, yNew, 1, 1, color);
        }
    }
}
