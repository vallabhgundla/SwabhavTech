using DeserializationApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DeserializationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"E:\serial.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Name  : " + s.Name);
            Console.WriteLine("Rollno: " + s.Rollno);
            
            stream.Close();
        }
    }
}
