using System.Collections.Immutable;
using System.Text;

namespace Requests
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random random = new();
            var array = new[] { random.Next(1, 5), random.Next(1, 5), random.Next(1, 5), random.Next(1, 5), random.Next(1, 5) };

            Console.WriteLine("початковий список:");
            foreach(int num in array)
            {
                Console.WriteLine(num);
            }

            var res = array.Distinct();
            res = res.ToImmutableSortedSet();

            Console.WriteLine("\nрезультат:");
            foreach (int num in res)
            {
                Console.WriteLine(num);
            }
        }
    }
}
