using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDesignPatternApp.Model;

namespace TemplateDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Build Concrete House..");
            HouseTemplate houseTemplate = new ConcreteHouse();

            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("\n Build Wooden house...");
            houseTemplate = new WoodenHouse();
            houseTemplate.BuildHouse();
            Console.ReadLine();
        }
    }
}
