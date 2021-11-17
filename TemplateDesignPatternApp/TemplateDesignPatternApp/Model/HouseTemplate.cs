using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPatternApp.Model
{
    public abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillers();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("Wel Come To New Build House...");

        }
        protected abstract void BuildFoundation();
        protected abstract void BuildPillers();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();

    }
}
