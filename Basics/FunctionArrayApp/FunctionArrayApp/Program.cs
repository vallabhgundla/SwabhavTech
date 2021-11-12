using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionArrayApp
{
    class Program
    {
        static int UpdateMarkToZero(int pmark)
        {
             pmark = 0;
             return pmark;
        }
        static void UpdateAllMarksToZero(int[] pmarks)
        {
          
            int temp = 0;
            /*
            for (int i = 0; i < pmarks.Length; i++)
            {
                temp = pmarks[i] +5;
                pmarks[i] = temp;
                Console.WriteLine(temp);
            }*/
            Console.WriteLine(pmarks.GetHashCode());
            for(int i = 0; i < pmarks.Length; i++)
            {
                pmarks[i] = 0;
            }
                
            }
        static void Main(string[] args)
        {
            int mark = 100;
            
            UpdateMarkToZero(mark);
            Console.WriteLine(mark);
            int[] marks = { 10, 20, 30, 40, 50 };
            UpdateAllMarksToZero(marks);
            foreach(int temp in marks)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
