using ArryListHashDictionaryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryListHashDictionaryApp
{
    class Program
    {
        static void Main()
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy1()
        {
            ArrayList a = new ArrayList();

            while (true)
            {
                Console.WriteLine("Pass y to go inside the menu and press E to exit...");
                char giveinput = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("1:Add 2:Read 3:Update 4:Delete");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            a.Add(num);
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("");
                            a.Read();
                            break;
                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            a.Update(num1, num2);
                            break;
                        case 4:
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            a.Delete(num3);
                            break;
                    }
                }
            }
        }
        private static void CaseStudy2()
        {
            Dictionary a = new Dictionary();

            while (true)
            {
                Console.WriteLine("Pass y to go inside the menu and press E to exit...");
                char giveinput = Convert.ToChar(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine("1:Add 2:Read 3:Update 4:Delete");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            int s1 = Convert.ToInt32(Console.ReadLine());
                            a.Create(num, s1);
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("");
                            a.Read();
                            break;
                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            a.Update(num1, num2);
                            break;
                        case 4:
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            a.Delete(num3);
                            break;
                    }
                }
            }
        }
        private static void CaseStudy3()
        {
            HashSet a = new HashSet();

            while (true)
            {
                Console.WriteLine("Pass y to go inside the menu and press E to exit...");
                char giveinput = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("1:Add 2:Read 3:Update 4:Delete");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            a.Create(num);
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("");
                            a.Read();
                            break;
                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            a.Update(num1, num2);
                            break;
                        case 4:
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            a.Delete(num3);
                            break;
                    }
                }
            }
        }
    }
}
