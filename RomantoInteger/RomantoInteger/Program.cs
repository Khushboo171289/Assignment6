using System;

namespace RomantoInteger
{
    class Program
    {
        public static int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }

        public static int RomantoInteger(string S)
        {
            int res = 0;
                for (int i = 0; i < S.Length ; i++)
                {
                    int s1 = value(S[i]);
                    if (i+1 < S.Length)
                    {
                        int s2 = value(S[i + 1]);
                        if (s1 >= s2)
                        {
                            res = res + s1;
                        }
                        else
                        {
                            res = res + s2 - s1;
                            i++;
                        }                        
                    }
                    else
                    {
                    res = res + s1;
                    i++;
                    }                    
                }
                return res;            
        }
        static void Main(string[] args)
        {
            string roman = "MCMIV";
            Console.WriteLine($"Integer value of roman string {roman} is : {RomantoInteger(roman)}");
            Console.ReadLine();
        }
    }
}
