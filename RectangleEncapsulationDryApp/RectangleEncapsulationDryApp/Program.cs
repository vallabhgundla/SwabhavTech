﻿using RectangleEncapsulationDryApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapsulationDryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.SetHeight(50);
            r1.SetWeight(40);
            displayInfo(r1);

            Rectangle r2 = new Rectangle();
            r2.SetHeight(5);
            r2.SetWeight(7);
            displayInfo(r2);

            Rectangle r3 = r2;
            r3.SetWeight(50);
            Console.WriteLine(r3.GetHeight());
            Console.WriteLine(r2.GetHeight());

            r1.SetHeight(r1.GetHeight()+10);
            Console.WriteLine("Get height:"+r1.GetHeight());

           // Console.WriteLine("area of anonlymous object is " + new Rectangle().CalculateArea());

        }
        private static void displayInfo(Rectangle r)
        {
            Console.WriteLine("Weight is:" + r.GetWidth());
            Console.WriteLine("Height is:" + r.GetHeight());
            Console.WriteLine("Area is:" + r.CalculateArea());
            Console.WriteLine("HashCode is:" + r.GetHashCode());
            /*
            displayInfo(new Rectangle());
            displayInfo(new Rectangle());
            */
        }
    }
}
