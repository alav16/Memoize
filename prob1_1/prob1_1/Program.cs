using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1_1
{
    public class Program
    {
        public static Func<T, T> Memoize<T>(Func<T, T> func)
        {
            Dictionary<T, T> cache = new Dictionary<T, T>();

            return (T x) =>
            {
                if (cache.ContainsKey(x))
                {
                    return cache[x];
                }

                T result = func(x);
                cache[x] = result;
                return result;
            };
        }
        static void Main(string[] args)
        {
            Func<int, int> factorial = (int n) =>
            {
                int res = 1;
                for (int i = 2; i < n; i++)
                {
                    res *= i;
                }
                return res;
            };

            var memo = Memoize(factorial);

            Console.WriteLine(memo(5));
            Console.WriteLine(memo(5));
            Console.WriteLine(memo(6));
        }
    }
}
