using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using GDIDrawer;

namespace Demo_16
{
    class Program
    {
        static CDrawer canvas = new CDrawer();
        static Random rand = new Random();
        static void Main(string[] args)
        {
            canvas.Scale = 10; //Create 80x60 array.

            Color[,] array1 = Randomize(60, 80, Color.AntiqueWhite);

            for (int i = 0; i < 2000; ++i)
            {
                DisplayArray(array1);
                array1 = RightShift(array1);
                array1 = DownShift(array1);
                Thread.Sleep(100);
            }

            Console.Write("\nPress Enter to End");
            Console.Read();
        }

        static Color[,] Randomize(int numRows, int numCols, Color color)
        {
            //Create a new array with 50% of each element being color, else black
            Color[,] retVal = new Color[numRows, numCols];
            //Visit each row
            for (int row = 0; row < numRows; row++)
                //Visit each column in that row
                for (int col = 0; col < numCols; col++)
                    //If %2 ==  0, a number is even
                    retVal[row, col] = rand.Next() % 2 == 0 ? Color.Black : color;
                    //                  -----50% chance -----   black if true --- otherwise color

            return retVal;
        }

        static void DisplayArray(Color[,] array)
        {
            //Visit each item
            for (int row = 0; row < array.GetLength(0); row++)
                for (int col = 0; col < array.GetLength(1); col++)
                    canvas.SetBBScaledPixel(col, row, array[row, col]);
        }

        static Color[,] RightShift(Color[,] orig)
        {
            //Shift all the colors to the right, with wrapping (rightmost becomes leftmost)
            //Returns a new array...no affect on old array.
            Color[,] repl = new Color[orig.GetLength(0), orig.GetLength(1)];
            //(1) Copy rightmost column of org to leftmost of repl
            for (int row = 0; row < orig.GetLength(0); row++)
                repl[row, 0] = orig[row, repl.GetUpperBound(1)];

            //(2) Copy remaining columns, one to left
            for (int col = 0; col < orig.GetLength(1) - 1; col++)
                for (int row = 0; row < orig.GetLength(0); row++)
                    repl[row, col + 1] = orig[row, col];

            return repl; //Return new one.
        }

        static Color[,] DownShift(Color[,] orig)
        {
            //Shift all the colors to the right, with wrapping (rightmost becomes leftmost)
            //Returns a new array...no affect on old array.
            Color[,] repl = new Color[orig.GetLength(0), orig.GetLength(1)];
            //(1) Copy rightmost column of org to leftmost of repl
            for (int col = 0; col < orig.GetLength(1); col++)
                repl[0, col] = orig[repl.GetUpperBound(0), col];

            //(2) Copy remaining columns, one to left
            for (int row = 0; row < orig.GetLength(0) - 1; row++)
                for (int col = 0; col < orig.GetLength(1); col++)
                    repl[row + 1, col] = orig[row, col];

            return repl; //Return new one.
        }
  
    }
}
