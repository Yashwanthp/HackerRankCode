using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _9Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(number));
        }

        public static int factorial(int number)
        {
            // 1.
            IEnumerable<int> ints = Enumerable.Range(1, number);
            return ints.Aggregate((f, s) => f*s);
            /*
                The first iteration passes in f = 1 and s = 2, which yields 1×2 = 2
                In the second iteration f is the result of the first iteration, i.e. 2 and s will be the second element, i.e. 3, yielding 2×3 = 6
                Then it continues with f = 6 from the second operation and taking 4 from the integer sequence, giving 6×4 = 24
                Finally we get 24×5 = 120
            */

            // 2.
            //int x = 1;
            //for (int i = number; i > 1; i = i - 2)
            //{
            //    x = x * i * (i - 1);
            //}
            //return x;
        }
    }
}
