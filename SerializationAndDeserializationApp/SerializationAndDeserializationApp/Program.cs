using SerializationAndDeserializationApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationAndDeserializationApp
{
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 101;
            s.Name = "Vallabh";
            

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\Serialization.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, s);
            stream.Close();

            stream = new FileStream("D:\\Deserialization.txt", FileMode.Open, FileAccess.Read);
            Student s1 = (Student)formatter.Deserialize(stream);

            Console.WriteLine(s1.Id);
            Console.WriteLine(s1.Name);

            Console.ReadKey();
        }
    }
}
