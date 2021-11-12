using System;


namespace CommandLineArgsUserDefApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string[] names = Console.ReadLine().Split(' ');
             
            Console.WriteLine("First Name is: " + names[0]);
            Console.WriteLine("Middle Name is: " + names[1]);
            Console.WriteLine("Last Name is: " + names[2]);
            
        }  
    }
}
