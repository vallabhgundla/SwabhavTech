using StudentProfessorDesignData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDesignData
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor(101, "Mumbai", "12/05/2020", 50000);
            Professor p1 = new Professor(102, "Solapur", "1/09/2019", 40000);

            Student s = new Student(103, "Pune", "12/09/2019", "CSE");
            Student s1 = new Student(104, "Navi-Mumbai", "15/06/2018", "IT");

            PrintDetails(p);
            PrintDetails(p1);
            PrintDetails(s);
            PrintDetails(s1);
        }

        public static void PrintDetails(Professor p)
        {
            Console.WriteLine("\n Id:" + p.Id);
            Console.WriteLine("Name:" + p.Address);
            Console.WriteLine("Date Of Birth:" + p.DateOfBirth);
            Console.WriteLine("Basic Salary:" + p.Basicsalary);
        }
        public static void PrintDetails(Student s)
        {
            Console.WriteLine("\n Id:" + s.Id);
            Console.WriteLine("Name:" + s.Address);
            Console.WriteLine("Date Of Birth:" + s.DateOfBirth);
            Console.WriteLine("Basic Salary:" + s.Branch);
        }
    }
}
