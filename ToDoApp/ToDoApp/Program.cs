using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> todo = new List<string>();
            Console.WriteLine("*******Welcome to TodoApp**********");
            bool b = true;
            while (b)
            {
                Console.WriteLine();
                Console.WriteLine("1.Display All Items");
                Console.WriteLine("2.Add the Elements");
                Console.WriteLine("3.Remove The Element");
                Console.WriteLine("4.Exit");
                Console.WriteLine();
                Console.WriteLine(" Enter Your Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    if (todo.Count == 0)
                    {
                        Console.WriteLine("List Empty..!");
                    }
                    foreach (var n in todo)
                    {
                        Console.WriteLine(n);
                    }
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter item to added: ");
                    string newItem = Console.ReadLine();
                    todo.Add(newItem);
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Remove Item In The List: ");
                    string newItem = Console.ReadLine();
                    todo.Remove(newItem);
                }
                else
                {
                    Console.WriteLine("Thank you for using this App...");
                    b = false;
                }
            }
            Console.ReadLine();
        }
    }
}
