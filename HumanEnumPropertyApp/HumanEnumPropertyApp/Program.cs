using HumanEnumPropertyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanEnumPropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Vallabh", 72, 6, GenderType.Male);
            PrintDetails(h);
            h.WorkOut();
            h.Eat();
            PrintDetails(h);
        }
        private static void PrintDetails(Human h)
        {
            Console.WriteLine("Name is :" + h.name);
            Console.WriteLine("height is :" + h.height);
            Console.WriteLine("Weight is :" + h.weight);
            Console.WriteLine("Gender is :" + h.gender);
            Console.WriteLine();
        }
    }
}
