using System;

namespace LongestCommanPrefix
{
    class Program
    {
        public static string ShortestString(string[] arr, int n)
        {
            int minlength = int.MaxValue;
            string x = "";
            for (int i = 0; i < n; i++)
            {
                int temp = arr[i].Length;
                if (temp < minlength )
                {
                    minlength = temp;
                    x = arr[i];
                }
            }
            return x;
        }

        public static string CommanPerfix(string[] arr, int n)
        {
            string min = ShortestString(arr, n);
            string test = "";
            if (arr[0].Length == min.Length )
            {
                test = arr[1];
            }else
            {
                test = arr[0];
            }
            for (int i = 0; i < min.Length; i++)
            {
                if (min[i] != test[i])
                {
                    return min.Substring(0, i);
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            string[] arr;
            arr = new string[] {"Ape", "App","April", "Apple"};
            int n = arr.Length;

            Console.WriteLine($"Longest comman substring is {CommanPerfix(arr, n)}");
            Console.ReadLine();
        }
    }
}
