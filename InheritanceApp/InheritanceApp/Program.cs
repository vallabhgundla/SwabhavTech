using InheritanceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();

        }
        private static void CaseStudy1()
        {
            Man x = new Man();
            x.Walk();
            x.Play();
            x.Read();

        }
        private static void CaseStudy2()
        {
            Boy y = new Boy();
            y.Play();
            y.Jump();
            y.Walk();
            y.Read();
        }
        private static void CaseStudy3()
        {
            Man x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
        }
        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }
        private static void CaseStudy5()
        {
            object x = 10;
            Console.WriteLine(x.GetType());
            Console.ReadLine();
            x = "Hello World";
            Console.WriteLine(x.GetType());
            Console.ReadLine();
            x = 10.55f;
            Console.WriteLine(x.GetType());
            Console.ReadLine();
            x = new Man();
            Console.WriteLine(x.GetType());

        }

        private static void AtThePark(Man man)
        {
            throw new NotImplementedException();
        }
    }
}
