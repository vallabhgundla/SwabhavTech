using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovableApp.Model
{
    class Bike:IMovable
    {
        public void move()
        {
            Console.WriteLine("I am Bike..");
        }
    }
}
