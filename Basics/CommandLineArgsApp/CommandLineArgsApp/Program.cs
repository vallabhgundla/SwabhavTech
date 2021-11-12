using System;

namespace CommandLineArgsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int i=0;
            if(i<=0)
            {
                Console.WriteLine("No argument passed");
            }
            else if(i>=5)
            {
                Console.WriteLine("passed arguments");

            }

        }
    }
}
