using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Circle c = new Circle();
            c.radius = 10;
            ConsoleColor BorderColor = ConsoleColor.Red;

            double AreaOfCircle = c.AreaOfCircle();
            Console.Write("The radius of circle is : {0} ", c.radius);
            Console.WriteLine("The area of yor circle : {0}", AreaOfCircle);

            double PerimeterOfCircle = c.PerimeterOfCircle();
            Console.WriteLine("The perimeter of circle : {0}", PerimeterOfCircle);

            Console.WriteLine("The color of circle : {0}", BorderColor);
            Console.WriteLine();



            /*
            
            double r, perimeter, area;
            Console.Write("Enter the radius of circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * Math.Pow(r, 2); 
            
            Console.WriteLine("The perimeter of circle : {0}", perimeter);
            Console.WriteLine("The area of yor circle : {0}", area);
            Console.WriteLine("The color of circle : {0}", BorderColor);
            Console.ReadKey();
            */

        }
    }
}
