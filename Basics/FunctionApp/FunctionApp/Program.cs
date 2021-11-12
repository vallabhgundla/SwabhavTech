using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionApp
{
    class Program
    {
      
        static int PrintLargest(int[] nos , int largest)
        {
            return nos.Max();
        }

        void PrintSumOf(int[] nos)
        {
                int sum = nos.Sum();
                Console.WriteLine("Sum is: " + sum);
        }
        void PrintAvg(int[] nos)
        {
            int sum=0;
            double avg;
            avg = sum / nos.Length;
            Console.WriteLine("Avg is: " + avg);
 
        }
        static void Main(string[] args)
        {
            int[] nos = { 1, 2, 3, 4};
            Program p = new Program();
            int larger = nos.Length;
            Console.WriteLine(PrintLargest(nos, larger));
            p.PrintSumOf(nos);
            p.PrintAvg(nos);
        }
    }
}
