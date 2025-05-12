using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_1
{
    public static class ListExtend
    {
        public static List<T> Filter<T>(this List<T> list, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach(T item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Anna", 35),
                new Student("Areg", 30),
                new Student("Lena", 15)
            };

            var filtered = students.Filter(s => s.Age > 20);

            foreach(Student student in filtered)
            {
                Console.WriteLine(student);
            }
        }
    }
}
