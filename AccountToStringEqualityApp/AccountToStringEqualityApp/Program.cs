
using AccountApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountToStringEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            Account a = new Account(101, "Vallabh", 15000);
            Console.WriteLine(a);
            Console.WriteLine(a.Tostring());

        }
        private static void CaseStudy2()
        {
            Acccount acc1 = new Acccount(101, "Vallabh", 15000);
            Account acc2 = new Account(101, "Vallabh", 15000);
            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
            Console.WriteLine(acc1 == acc2);
            Console.WriteLine(acc1.Equals(acc2));

        }
    }
}
