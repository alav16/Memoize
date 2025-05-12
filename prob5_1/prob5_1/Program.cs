using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_1
{
    public static class ListEx
    {
        public static bool Every<T>(this List<T> list, Func<T, bool> predicate)
        {
            foreach (T item in list)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Anna", "Alina", "Aonte" };

            bool allStart = names.Every(name => name.StartsWith("A"));
            Console.WriteLine(allStart);
        }
    }
}
