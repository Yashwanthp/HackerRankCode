using System;

namespace _112DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
          

                //var temp_string_arr = new[]
                //{
                //    "1 1 1 0 0 0","0 1 0 0 0 0","1 1 1 0 0 0","0 0 2 4 4 0","0 0 0 2 0 0","0 0 1 2 4 0"
                //};
            //var temp_string_arr = new[]
            //{
            //    "-1 -1 0 -9 -2 -2", "-2 -1 -6 -8 -2 -5","-1 -1 -1 -2 -3 -4","-1 -9 -2 -4 -4 -5","-7 -3 -3 -2 -9 -9","-1 -3 -1 -2 -4 -5"
            //};
            

            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                //string[] arr_temp = temp_string_arr[arr_i].Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int[] sum = new int[100];
            int counter = 0;
            var maxValue = Int32.MinValue;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("i: " + i + "j: " + j);
                    sum[counter] = arr[i][j]      +   arr[i][j+1]       +    arr[i][j+2] + 
                                                      arr[i + 1][j + 1]   + 
                                    arr[i+2][j] +   arr[i + 2][j+1]   +    arr[i + 2][j+2];
                   
                    if (sum[counter] > maxValue)
                    {
                        maxValue = sum[counter];
                    }
                    counter = counter + 1;
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
