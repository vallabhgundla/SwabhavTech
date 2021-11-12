using RectangleEncapsulationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            r1 = new Rectangle();
            r1.SetWidthAndHeight(5,15);

            Console.WriteLine("Width is:" + r1.Getwidth());
            Console.WriteLine("Heigth is :" + r1.Getheight());
            Console.ReadLine();
        }
    }
}