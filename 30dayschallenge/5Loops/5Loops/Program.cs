using System;

namespace _5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>=2 && n<=20)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}",n,i,n * i);
                }
            }
           
        }
    }
}
