using System;

namespace _6LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int noofTestCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < noofTestCases; i++)
            {
                string s = Console.ReadLine();
                string evenString = string.Empty;
                string oddString = string.Empty;
                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenString += s[j];
                    }
                    else
                    {
                        oddString += s[j];
                    }
                }
                Console.WriteLine(evenString + " " + oddString);
            }
        }
    }
}
