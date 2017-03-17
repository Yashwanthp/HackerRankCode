using System;

namespace _10BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var binary = Convert.ToString(Convert.ToInt32(n), 2);
            
            int consecutiveone = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int thisIterationConsecutiveCount = 0;
                if (binary[i].ToString() == "1")
                {
                    thisIterationConsecutiveCount++;
                    if (thisIterationConsecutiveCount > consecutiveone)
                    {
                        consecutiveone = thisIterationConsecutiveCount;
                    }
                    for (int j = i+1; j < binary.Length; j++)
                    {
                        if (binary[j].ToString() == "1")
                        {
                            thisIterationConsecutiveCount++;
                            if (thisIterationConsecutiveCount > consecutiveone)
                            {
                                consecutiveone = thisIterationConsecutiveCount;
                            }
                        }
                        else if (binary[j].ToString() == "0")
                        {
                            i = j;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(consecutiveone);
        }
    }
}
