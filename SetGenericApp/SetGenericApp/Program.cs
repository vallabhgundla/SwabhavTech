using SetGenericApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();

        }

        private static void CaseStudy1()
        {
            HashSet<int> nos = new HashSet<int>();
            nos.Add(10);
            nos.Add(200);
            nos.Add(5);
            nos.Add(5);
            nos.Add(300);
            Console.WriteLine("Count:" + nos.Count());
            foreach(int item in nos)
            {
                Console.WriteLine(item);
            }
        }
        private static void CaseStudy2()
        {
            
            Student s1=new Student(101, "Vallabh", "Solapur");
            Console.WriteLine(s1.GetHashCode(s1));
            Student s2 = new Student(101, "Vallabh", "Solapur");
            Console.WriteLine(s2.GetHashCode(s2));

            HashSet<Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2);

            Console.WriteLine("Count:" + students.Count());
           
        }
    }
}
