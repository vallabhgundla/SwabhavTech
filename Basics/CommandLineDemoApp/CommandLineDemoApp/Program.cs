using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLineDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] str = args;
           int num = Convert.ToInt32(args[0]);
          
            for (int i = 0; i<=num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); 
                }
            }
          


            /*
             Console.WriteLine("Even Numbers :");
             for (int i = 0; i <=args.Length; i++)
             {

                 if (i % 2 == 0)
                 {
                    // Console.WriteLine(args[i]);
                    Console.WriteLine(i.ToString());
                }
             }*/


        }
    }
}
