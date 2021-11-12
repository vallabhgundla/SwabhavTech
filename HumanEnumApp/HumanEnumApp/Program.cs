using HumanEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Vallabh" , 72 , 6 , GenderType.Male);
            PrintDetails(h);
            h.WorkOut();
            h.Eat();
            PrintDetails(h);
        }
        private static void PrintDetails(Human h)
        {
            Console.WriteLine("Name is :" + h.Getname());
            Console.WriteLine("height is :" + h.Getheight());
            Console.WriteLine("Weight is :" + h.Getweight());
            Console.WriteLine("Gender is :" + h.GetGender());
            Console.WriteLine();
        }
    }
}
