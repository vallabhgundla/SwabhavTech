using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CircleEncapsulationApp;
using CircleEncapsulationApp.model;

class Program
    {
        public static void Main(string[] args)
        {
            Circle c1;
            c1 = new Circle();
            c1.SetRadius(-1);
            Console.WriteLine("radius of circle:" + c1.GetRadius());
            c1.SetColor("Black");
            Console.WriteLine("color of circle:" + c1.GetColor());
            Console.ReadLine();

        }
    }

