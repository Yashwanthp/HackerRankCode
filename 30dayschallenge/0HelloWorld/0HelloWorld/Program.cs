using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Printing Hello, World and user input
/// </summary>
namespace _0HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "";
            inputString = Console.ReadLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine(inputString);
            Console.ReadLine();
        }
    }
}
