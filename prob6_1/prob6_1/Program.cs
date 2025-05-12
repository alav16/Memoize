using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob6_1
{
    public static class ListEx
    {
        public static T Find<T>(this List<T> list, Func<T, bool> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            int even = nums.Find(n => n %2 == 0);

            Console.WriteLine(even);
        }
    }
}
