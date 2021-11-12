using SerializationApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\serial.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student("Vallabh",100);
            formatter.Serialize(stream, s);

            stream.Close();
            Console.WriteLine("File saved:" + path);
            Console.ReadLine();

        }
    }
}
