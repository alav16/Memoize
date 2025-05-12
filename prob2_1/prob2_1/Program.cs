using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2_1
{
    internal class Program
    {
        public static (Func<int, bool> IsPrime, Action ClearCache) ManagedCache()
        {
            Dictionary<int, bool> cache = new Dictionary<int, bool>();

            Func<int, bool> isPrime = (int num) =>
            {
                if (cache.ContainsKey(num))
                {
                    Console.WriteLine("from cache");
                    return cache[num];
                }

                for (int i = 2; i * i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                cache[num] = true;
                return true;
            };

            Action clearCache = () =>
            {
                cache.Clear();
            };

            return (isPrime, clearCache);
        }
        static void Main(string[] args)
        {
            var fn = ManagedCache();

            Console.WriteLine(fn.IsPrime(7));
            Console.WriteLine(fn.IsPrime(7));

            fn.ClearCache();

            Console.WriteLine(fn.IsPrime(7));
        }
    }
}
