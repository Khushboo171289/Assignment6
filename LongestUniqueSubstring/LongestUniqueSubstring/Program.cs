using System;
using System.Collections.Generic;

namespace LongestUniqueSubstring
{
    class Program
    {
        public static string UniqueSubstring(string a)
        {
            //maxlen and start to keep the track of maxlength unique sbustring lenght and start position
            int maxlen = 0;
            int start = 0;
            //curlen and st to keep the track of Current unique sbustring lenght and start position
            int curlen = 0;
            int st = 0;
            int i;
            //dict to store the char and its location in string as key value pair
            Dictionary<char, int> Visited = new Dictionary<char, int>();
            Visited.Add(a[0], 0);
            int len = a.Length;
            for (i = 1; i < len; i++)
            {
                //Id dictionary already have the char
                if (Visited.ContainsKey(a[i]))
                {
                    // check wether the visited char lies before or after the start of the current substring
                    if (Visited[a[i]] >= st)
                    {
                        //Calculate length of current sunstring
                        curlen = i - st;
                        //If current substring lenght is gestest so far , update ythe max length and start position
                        if (maxlen < curlen)
                        {
                            maxlen = curlen;
                            start = st;
                        }
                        //upadte the starting position of new substring
                        st = Visited[a[i]] + 1;
                    }
                    //update the value of char in dictionary as the current index of that char 
                    Visited[a[i]] = i;
                }
                else
                {
                    Visited.Add(a[i], i);
                }
            }
            if (maxlen < i-st)
            {
                maxlen = i - st;
                start = st;
            }
            return a.Substring(start, maxlen);
        }
        static void Main(string[] args)
        {
            string a = "GEEKSFORGEEKS";
            string output = UniqueSubstring(a);
            Console.WriteLine($"Longest unique substring is {output} of length {output.Length}");
            Console.ReadLine();
        }
    }
}
