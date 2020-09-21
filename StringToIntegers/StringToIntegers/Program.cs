using System;

namespace StringToIntegers
{
    class Program
    {
        public static int atoi(string s)
        {
            if (s.Length == 0)
            {
                return -1;
            }
            int sign = 1;
            int i = 0;
            int result = 0;
            for (; i < s.Length; i++)
            {
                while (char.IsWhiteSpace(s[i]))
                {
                    i++;
                }
                if (s[i] == '-')
                {
                    sign = -1;
                    i++;
                }              
                if(char.IsDigit(s[i])  == false)
                {
                    return result;
                }
                result = result * 10 + int.Parse(s[i].ToString());
            }
            return result * sign;
        }
        static void Main(string[] args)
        {
            string a = "  123456abc";
            int x = atoi(a);
            Console.WriteLine($"Interger conversion of string {a} is {x}");
            Console.ReadLine();
        }
    }
}
