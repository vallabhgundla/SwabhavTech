using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovableApp.Model
{
    class Car:IMovable
    {
        public void move() 
        {
            Console.WriteLine("I am Car, I move By wheel");
        }

    }
}
