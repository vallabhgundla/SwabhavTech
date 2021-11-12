using RectangleConstructorApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10,5);
            Console.WriteLine("area of anonlymous object is " + new Rectangle(8, 5).CalculateArea());
            displayInfo(new Rectangle(10, 5));

            Rectangle[] rectangles= new Rectangle[4];
            Console.Write("\nElements in array are: \n\n");

            Console.WriteLine("First Index:");
            rectangles[0] = new Rectangle(9, 5);
            displayInfo(rectangles[0]);
            Console.Write("\n");

            Console.WriteLine("Second Index:");
            rectangles[1] = new Rectangle(12, 7);
            displayInfo(rectangles[1]);
            Console.Write("\n");

            Console.WriteLine("Third Index:");
            rectangles[2] = new Rectangle(13, 8);
            displayInfo(rectangles[2]);
            Console.Write("\n");

            Console.WriteLine("Fourth Index:");
            rectangles[3] = new Rectangle(11, 6);
            displayInfo(rectangles[3]);
            Console.Write("\n");

        }
        private static void displayInfo(Rectangle rectangle)
        {
            Console.WriteLine("width is:" + rectangle.GetWidth());
            Console.WriteLine("height is:" + rectangle.GetHeight());
            Console.WriteLine("area is:" + rectangle.CalculateArea());
        } 
    }
}
