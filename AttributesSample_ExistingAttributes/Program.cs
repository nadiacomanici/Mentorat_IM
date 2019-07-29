using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using AttributesSample_ExistingAttributes.Classes;

namespace AttributesSample_ExistingAttributes
{
    class Program
    {
        private static List<SerializableStudent> CreateOrLoadList()
        {
            string fullFilePath = @"D:\ExampleNew.txt";
            var formatter = new BinaryFormatter();

            List<SerializableStudent> students;

            if (File.Exists(fullFilePath))
            {
                var stream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read);
                students = (List<SerializableStudent>)formatter.Deserialize(stream);
            }
            else
            {
                students = new List<SerializableStudent>();

                students.Add(new SerializableStudent(1, "Nadia", "Comanici"));
                students.Add(new SerializableStudent(2, "Marian", "Ionescu"));
                students.Add(new SerializableStudent(3, "Geoge", "Popescu"));

                using (var stream = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, students);
                }
            }

            return students;
        }

        static void Main(string[] args)
        {
            List<SerializableStudent> students = CreateOrLoadList();

            // Obsolete attribute
            Console.WriteLine(students[0].FormattedDescription);

        }
    }
}
