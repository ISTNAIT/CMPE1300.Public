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
        const int speed = 100; //Frames per second

        static void Main(string[] args)
        {
            Random rand = new Random();
            Drawer.Scale = 5;

            for (int i = 0; i < 100; ++i)
                MoveBrickFromTo(rand.Next(800 / Drawer.Scale),
                    rand.Next(600 / Drawer.Scale),
                    rand.Next(800 / Drawer.Scale),
                    rand.Next(600 / Drawer.Scale),
                    RandColor.GetColor());

        }

        static private void MoveBrick(int xOld, int yOld, int xNew, int yNew, Color color)
        {
            //Erase brick at old, draw a brick of color color at new
            Drawer.AddRectangle(xOld, yOld, 1, 1, Color.Black);
            Drawer.AddRectangle(xNew, yNew, 1, 1, color);
        }

        static private void MoveBrickFromTo(int xOld, int yOld, int xNew, int yNew, Color color)
        {
            //Paint initial brick
            int xCurr = xOld;
            int yCurr = yOld;
            Drawer.AddRectangle(xCurr, yCurr, 1, 1, color);

            //Need to decide if I'm going left or right
            int increment = 0;

            if (xOld < xNew) //Moving right
                increment = 1;
            else if (xNew < xOld) //moving left
                increment = -1;
            else //moving vertically
                increment = 0;

            if (increment != 0) //Not vertical
            {
                //Figure out the line parameters to go from Old to New
                int slope = Slope(xOld, yOld, xNew, yNew);
                int intercept = Intercept(xOld, yOld, xNew, yNew);

                for (int p = xOld; p != xNew; p = p + increment)
                {
                    //Pause for frame
                    Thread.Sleep(1000 / speed);
                    //Calculate new point (trig is fun!)
                    int xNext = p;
                    int yNext = slope * p + intercept;
                    //Erase current, draw next one on x
                    MoveBrick(xCurr, yCurr, xNext, yNext, color);
                    //Reset current point for next iteration
                    xCurr = xNext;
                    yCurr = yNext;
                }
            }
            else //need to paint vertically
            {
                //(yNew - yOld) / Math.Abs(yNew - yOld) will be +1 for going down, -1 for going up
                for (int y = yOld; y != yNew; y = y + (yNew - yOld) / Math.Abs(yNew - yOld))
                {
                    Thread.Sleep(1000 / speed);
                    MoveBrick(xNew, yCurr, xNew, y, color);
                    yCurr = y;
                }

            }



        }

        static int Slope(int xO, int yO, int xN, int yN)
        {
            return (yN - yO) / (xN - xO);
        }

        static int Intercept(int xO, int yO, int xN, int yN)
        {
            int slope = Slope(xO, yO, xN, yN);
            return yN - slope * xN;
        }

    }
}
