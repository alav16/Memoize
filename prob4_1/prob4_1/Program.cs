using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4_1
{
    public static class ListExtend
    {
        public static List<TResult> Map<T, TResult>(this List<T> list, Func<T, TResult> transform)
        {
            List<TResult> res = new List<TResult>();
            foreach(T item in list)
            {
                res.Add(transform(item));
            }
            return res;
        }
        
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4 };

            List<string> strs = nums.Map(n => $"{n}");

            foreach(var s in strs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
