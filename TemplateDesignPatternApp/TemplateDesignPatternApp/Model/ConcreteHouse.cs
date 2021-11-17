using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPatternApp.Model
{
    class ConcreteHouse:HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron, steel and wood");
        }
        protected override void BuildPillers()
        {
            Console.WriteLine("Building wood Pillers with Wood coating..");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Wall.");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows.");
        }
    }
}
