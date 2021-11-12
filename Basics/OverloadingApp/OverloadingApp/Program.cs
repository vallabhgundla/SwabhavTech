using System;

namespace OverloadingApp
{
    class Program
    {
        static void PrintInfo(string s)
        {
            Console.WriteLine("Overload 1 (string)");
            Console.WriteLine(s);
             
        }
        static void PrintInfo(int a)
        {
            Console.WriteLine("Overload 2 (Integer)");
            Console.WriteLine(a);
        }
        static void PrintInfo(double d)
        {
            Console.WriteLine("Overload 3  (Double)");
            Console.WriteLine(d);
            
        }
        static void PrintInfo(float f)
        {
            Console.WriteLine("Overload 4 (Float)");
            Console.WriteLine(f);
        }
        static void PrintInfo(bool b)
        {
            Console.WriteLine("Overload 5 (Boolean)");
            Console.WriteLine(b);
        }
        static void PrintInfo(char c)
        {
            Console.WriteLine("Overload 6 (Charecter)");
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            PrintInfo("Vallabh");
            PrintInfo(100);
            PrintInfo(10.5);
            PrintInfo(12.5f);
            PrintInfo(true);
            PrintInfo('%');







        }
    }
}
