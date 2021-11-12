using System;

namespace BasicsDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

           
            if (num % 2 == 0)
            {
                Console.WriteLine("Number Is Even....");
            }
            else
            {
                Console.WriteLine("Number Is Odd.....");
            }
        }
    }
}
