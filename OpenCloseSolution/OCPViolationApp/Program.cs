using OCPViolationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp
{
    class Program
    {
        private static object festivalType;

        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Vallabh", 100000, 10, festivalType.Normal);
            Console.WriteLine(fd1.SimpleInterest());
        }
    }
}
