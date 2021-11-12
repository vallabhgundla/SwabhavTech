﻿using GenericDictApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictApp
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
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(1, "ONE");
            map.Add(2, "Two");

            Console.WriteLine("Count:" + map.Count());
            foreach (KeyValuePair<int,string> item in map)
            {
                Console.WriteLine("Key:{0}, value:{1}",item.Key,item.Value);
            }

        }
        
        private static void CaseStudy2()
        {
            var map = new Dictionary<Student, Student>();

            var s1 = new Student(12, 10, "Vinay", "Mumbai");
            var s2 = new Student(10, 12, "Vallabh", "Mumbai");
            var s3 = new Student(12, 10, "VINAY", "MUMBAI");

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            map.Add(s1, s1);
            map.Add(s2, s2);

            if (!map.ContainsKey(s3))
            {
                map.Add(s3, s3);
            }
            Console.WriteLine("Count:" + map.Count());
        
        }
    }
}
