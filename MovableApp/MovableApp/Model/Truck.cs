using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovableApp.Model
{
    class Truck:IMovable
    {
        public void move()
        {
            Console.WriteLine("I am Truck, I move By wheel");
        }
    }
}
