using System;
using System.Collections.Generic;

namespace RemoveAdjacentDuplicate
{
    class Program
    {
        public static string removeAdjacentDuplicate(string str, char last_removed)
        {
            if (str.Length == 1 || str.Length == 0)
            {
                return str;
            }
            if (str[0] == str[1])
            {
                last_removed = str[0];
                while (str[0] == str[1]  && str.Length > 1)
                {
                    str = str.Substring(1);
                }
                str = str.Substring(1);
                return removeAdjacentDuplicate(str, last_removed);
            }

            string str_removed = removeAdjacentDuplicate(str.Substring(1), last_removed);
            if (str_removed.Length > 0 && str[0] == str_removed[0])
            {
                last_removed = str[0];
                return str_removed.Substring(1);

            }
            if (str_removed.Length == 0 && last_removed == str[0])
            {
                return str_removed;
            }
            return (str[0] + str_removed);


        }
        static void Main(string[] args)
        {
            string input = "azxxzy";
            char c = '\0';
            Console.WriteLine($" {removeAdjacentDuplicate(input, c)}");
            Console.ReadLine();
        }
    }
}
