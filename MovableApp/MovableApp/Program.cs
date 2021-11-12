using MovableApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMovable> lstMovable = new List<IMovable>
            {
               new Car(),
               new Bike(),
               new Truck()
            };

            foreach (IMovable movableType in lstMovable)
            {
                movableType.move();
               
            }
            Console.ReadLine();
        }
    }
}
