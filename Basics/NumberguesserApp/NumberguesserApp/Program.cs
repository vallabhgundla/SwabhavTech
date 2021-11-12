using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberguesserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(1, 100);
            bool win = false;
            do
            {
                Console.Write("Guess number between 1 to 100 :");
                string s = Console.ReadLine();

                int i = int.Parse(s);
                if (i > winNum)
                {
                    Console.WriteLine(" Sorry To High..! Guess Lower....");
                }
                else if (i < winNum)
                {
                    Console.WriteLine(" Sorry To Low...!  Guess High....");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Winner winner chicken dinner...!");
                    win = true;
                }
                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank You For Playing Game...!");           
            Console.ReadKey(true);
        }
    }
}
