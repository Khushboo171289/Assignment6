using System;

namespace LocateStringOccurance
{
    class Program
    {
        public static int Strstr(string a, string b)
        {
            int len1 = a.Length;
            int len2 = b.Length;
            int j = 0;
            if (len2 == 0)
            {
                return 0;
            }
            for (int i = 0; i < len1; i++)
            {
                if (a[i] == b[j])
                {
                    while(j < len2 && a[i] == b[j])
                    {
                        i++;
                        j++;
                    }
                    if (j == len2)
                    {
                        return (i - j);
                    }
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            string a = "Geeksforgeeks";
            string b = "for";
            int loc = Strstr(a, b);
            if(loc > 0)
                Console.WriteLine($"String {b} occurs in the string {a} at index {loc}");
            else
                Console.WriteLine($"String {b} do not occur in the string {a} ");
            Console.ReadLine();
        }
    }
}
