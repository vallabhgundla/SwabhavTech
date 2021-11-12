using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void main(String[] args)
        {
            try
            {
                M1();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
            Console.WriteLine("End Of Main");
        }
        private static void M1()
        {
            Console.WriteLine("Inside M1");
            M2();
        }
        private static void M2()
        {
            Console.WriteLine("Inside M2..");
            M3();

        }
        private static void M3()
        {
            Console.WriteLine("Inside M3..");
            throw new Exception("\n Something Went Wrong....");
        }
    }
}
