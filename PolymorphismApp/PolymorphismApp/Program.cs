using PolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PolymorphismApp.Model.Shape;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Shape square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Shape rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());



        }
    }
}
