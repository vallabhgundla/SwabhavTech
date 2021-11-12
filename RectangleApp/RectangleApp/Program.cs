using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            x = 10;
            Rectangle big;
            big = new Rectangle();

            big.width = 100;
            big.height = 50;

            int areaOfBig = big.CalculateArea();

            Console.WriteLine("Widht Of Big recatngle :" + big.width);
            Console.WriteLine("Height Of Big rectangle :" + big.height);
            Console.WriteLine("Area of Rectangle :" + areaOfBig);

        }
    }
}
