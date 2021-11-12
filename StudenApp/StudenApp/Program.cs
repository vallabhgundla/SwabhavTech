using StudenApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.SetId(101);
            Console.WriteLine("Student Id:" + s.GetId());
            s.SetName("Vallabh");
            Console.WriteLine("Student Name:" + s.GetName());
            s.SetCgpa(9.5);
            Console.WriteLine("Student Cgpa:" + s.GetCgpa());
            Console.WriteLine("Student Percentage:" + s.calculatePercentage());
            Console.WriteLine("Grade :" + s.GetGrade());


        }
    }
}
