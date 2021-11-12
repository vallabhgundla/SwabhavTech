using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallByRefApp
{
    class Program
    {
        public void Show(ref int val)
        {
            val *= val;  
            Console.WriteLine(" inside the show function " + val);
        }
        static void Main(string[] args)
        {
            int val = 15;
            Program p = new Program();  
            Console.WriteLine(" before calling the function " + val);
            p.Show(ref val);   //      
            Console.WriteLine(" after calling the function " + val);
        }
    }
}
