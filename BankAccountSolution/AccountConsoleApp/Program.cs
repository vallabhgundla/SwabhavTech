using AccountLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Advait", 1000);
            Console.WriteLine(acc1.GetAccount());
            Console.WriteLine(acc1.GetCount());
            Console.WriteLine();

            Account acc2 = new Account(102, "Vallabh", 2000);
            Console.WriteLine(acc1.GetAccount());
            Console.WriteLine(acc1.GetCount());
            Console.WriteLine();


            Account acc3 = new Account(103, "Aarti", 3000);
            Console.WriteLine(acc1.GetAccount());
            Console.WriteLine(acc1.GetCount());
            Console.WriteLine();

        }
    }
}
