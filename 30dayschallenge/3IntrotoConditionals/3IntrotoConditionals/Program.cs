using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3IntrotoConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >=1 && N <=100)
            {
                if (N % 2 != 0)
                {
                    Console.WriteLine("Weird");
                }
                else if (N % 2 == 0 && N >= 2 && N <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (N > 20 && N % 2 == 0)
                {
                    Console.WriteLine("Not Weird");
                }
            }
            
        }
    }
}
