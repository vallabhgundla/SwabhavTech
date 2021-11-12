using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            float avg = 0.0f;
            int i = 0;
            int Max = 0;
            Console.WriteLine("Enter the Element: ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Sum of all elements stored in the array is " + sum);

            avg = (float)sum / arr.Length;

            Console.Write("Avg of all elements stored in the array is " + avg);

            Max = arr[0];
            for (i = 1; i < arr.Length;i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];

                }
                Console.WriteLine("Max array is:{0}\n", Max);
            }
        }
    }
}
