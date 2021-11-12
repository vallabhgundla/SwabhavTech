using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallByValueApp
{
    class Program
    {
        public void Show(int val)
        {
            val *= val; 
            Console.WriteLine("Value inside function " + val);
        }
        static void Main(string[] args)
        {
            int val = 10;
            Program p = new Program();
            Console.WriteLine(" before calling the function " + val);
            p.Show(val);           
            Console.WriteLine(" after calling the function " + val);
        }
    }
}
