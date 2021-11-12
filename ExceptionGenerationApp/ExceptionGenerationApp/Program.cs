using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNo = int.Parse(args[0]);
            int SecondNo = int.Parse(args[1]);
            int result = FirstNo / SecondNo;

            Console.WriteLine("{0} / {1} ={2} ", FirstNo, SecondNo, result);
            Console.WriteLine("End Of Main....");



        }
    }
}
