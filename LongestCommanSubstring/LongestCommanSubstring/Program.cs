using System;

namespace LongestCommanSubstring
{
    class Program
    {
        public static void LCommonSubstring(string a, string b)
        {
            int M = a.Length;
            int N = b.Length;
            int len = 0;
            int row = 0, col = 0;
            int[,] track;
            track = new int[M+1,N+1];

            for (int i = 0; i <= M; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    if (i == 0 || j ==0)
                    {
                        track[i, j] = 0;
                    }
                    else
                    {
                        if (a[i-1] == b[j-1])
                        {
                            track[i, j] = track[i - 1, j - 1] + 1;
                            if (len < track[i,j])
                            {
                                len = track[i, j];
                                row = i;
                                col = j;
                            }
                        }
                        else
                        {
                            track[i, j] = 0;//Math.Max(track[i, j - 1], track[i - 1, j]);
                        }
                    }
                }
               
            }
            string result = "";
            while (track[row, col] != 0)
            {
                result = a[row - 1] + result;

                row--;
                col--;
            }

            Console.WriteLine($"The longest common substring is {result} and is oflength {len}.");

        }
        static void Main(string[] args)
        {
            string a = "zxabcdezy";
            string b = "yzabcdezx";
            LCommonSubstring(a, b);
            Console.ReadLine();
        }
    }
}
