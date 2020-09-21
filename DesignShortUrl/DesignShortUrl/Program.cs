using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignShortUrl
{
    class Program
    {
        public static Dictionary<string, int> OurlToint;
        public static int Id =100;

        public static string convertToShortUrl(string OUrl)
        {
            string shortUrl;
            int urlid;
            if (OurlToint.ContainsKey(OUrl))
            {
                urlid = OurlToint[OUrl];
                shortUrl = encode(urlid);
            }else
            {
                OurlToint.Add(OUrl, Id);
                urlid = OurlToint[OUrl];
                shortUrl = encode(urlid);
                Id++;   
            }

            return shortUrl;
        }

        private static string encode(int id)
        {
            string shorturl="";
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int baselog = characters.Length;
            while (id > 0)
            {
                int temp = id % baselog;
                shorturl = shorturl + characters[temp];
                id = id / baselog;
            }

            //shorturl = shorturl.Reverse().ToString();
            var result = new string(shorturl.ToCharArray().Reverse().ToArray());
            return "shorturl.com/"+result;
        }

        public static string ConvertToOriginalUrl(string s)
        {
            int id = 0;
            string shorturl = s.Substring(13);
            for (int i = 0; i < shorturl.Length; i++)
            {
                if ('a' <= shorturl[i] && shorturl[i] <= 'z')
                    id = id * 62 + shorturl[i] - 'a';

                if ('A' <= shorturl[i] && shorturl[i] <= 'Z')
                    id = id * 62 + shorturl[i] - 'A' + 26;

                if ('0' <= shorturl[i] && shorturl[i] <= '9')
                    id = id * 62 + shorturl[i] - '0' + 52;

            }
            string result = "";
            foreach (var item in OurlToint)
            {
                if (item.Value==id)
                {
                    result = item.Key;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            OurlToint = new Dictionary<string, int>();
            
            string OriginalUrl = "goooooogle.com";
            string OriginalUrl1 = "goooooogleijkl.com";
            string OriginalUrl2 = "goooooogle.com";
            string OriginalUrl3 = "gooooooglebhdgyxhcyefshysv.com";
            string OriginalUrl4 = "https://coding_interview.com/questions/183658/replacing-letters-with-number";

            Console.WriteLine(OriginalUrl);
            Console.WriteLine($"{convertToShortUrl(OriginalUrl)}");
            Console.WriteLine(OriginalUrl1);
            Console.WriteLine($"{convertToShortUrl(OriginalUrl1)}");
            Console.WriteLine(OriginalUrl2);
            Console.WriteLine($"{convertToShortUrl(OriginalUrl2)}");
            Console.WriteLine(OriginalUrl3);
            Console.WriteLine($"{convertToShortUrl(OriginalUrl3)}");
            Console.WriteLine(OriginalUrl4);

            Console.WriteLine($"{convertToShortUrl(OriginalUrl4)}");
            string short4 = convertToShortUrl(OriginalUrl4);
            Console.WriteLine($"Original Url is {ConvertToOriginalUrl(short4)}");

            Console.ReadLine();
        }
    }
}
