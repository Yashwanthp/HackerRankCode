using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8DictionaryandMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = Convert.ToInt32(Console.ReadLine());
            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < numbers; i++)
            {
                string[] s = Console.ReadLine().Split();
                dictionary.Add(s[0], int.Parse(s[1]));
            }
            for (int i = 0; i < numbers; i++)
            {
                string search = Console.ReadLine();
                if (dictionary.ContainsKey(search))
                {
                    Console.WriteLine(search + "=" +dictionary[search]);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
