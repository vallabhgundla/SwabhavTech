using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileReadWriteApp
{
    class Program
    {

        static void Main(string[] args)
        {
            
            try
            {              
                StreamWriter sw = File.AppendText("E:\\Test.txt");
                sw.WriteLine("Hello World!!");              
                sw.WriteLine("From the StreamWriter class");                  
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
