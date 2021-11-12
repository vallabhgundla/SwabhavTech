using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProofOfStringImmutabilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Wel-Come To Hello World";
            string s2 = s1;
            s2 = "Wel-Come To C# World";
            if (object.ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
