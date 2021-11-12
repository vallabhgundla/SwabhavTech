using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionEvenOddApp
{
    class Program
    {
        static void EvenAndOdd(int stVal, int n)
        {
            if (stVal > n)
            {
                return;
            }
               
            Console.Write(" {0}  ", stVal);
            EvenAndOdd(stVal + 2, n);
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write(" Enter the range to print starting from 0 : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n All even numbers from 0 to {0} : ", n);
            EvenAndOdd(2, n);

            Console.WriteLine("\n\n All odd numbers from 0 to {0} : ", n);
            EvenAndOdd(1, n);
            Console.WriteLine();

            return;
        }
    }
}
