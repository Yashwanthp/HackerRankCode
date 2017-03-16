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
            int x = 1;
            for (int i = number; i > 1; i = i - 2)
            {
                x = x * i * (i - 1);
            }
            return x;
        }
    }
}
