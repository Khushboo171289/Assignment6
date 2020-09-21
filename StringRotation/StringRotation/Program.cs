using System;

namespace StringRotation
{
    class Program
    {
        public static void StringRotation(string a, string b, int n)
        {
            string anticlock = a;
            string clock = a;
            while (n >0)
            {
                char temp1 = anticlock[0];               
                anticlock = anticlock.Substring(1) + temp1;

                char temp2 = clock[clock.Length-1];
                clock = temp2 + clock.Substring(0, clock.Length - 1);
                n--;
            }

            if (anticlock == b)
            {
                Console.WriteLine($"Rotation anticlockwise of {a} by two places gives {b} : True");
            }
            else if (clock == b)
            {
                Console.WriteLine($"Rotation clockwise {a} by two places gives {b} : True");
            }else
            {
                Console.WriteLine($"Rotation clockwise and anticlockwise {a} by two places does not gives {b} : False");
            }
        }
        static void Main(string[] args)
        {
            string a = "amazon";
            string b = "onamaz";
            int shift = 2;
            StringRotation(a, b, shift);
            Console.ReadLine();
        }
    }
}
