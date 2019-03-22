using System;

namespace Ex08
{
    static class Utils
    {
        static public bool isCountryCode(this string code)
        {
            string[] codes = { "my", "sg", "jp", "cn", "kr", "in", "uk" };
            foreach (string c in codes)
            {
                if (code == c) return true;
            }
            return false;
        }
    }

    class Program
    {
   
        static void Main(string[] args)
        {
            //string s1 = "ABC";
            //string s2 = "ABC";
            //string s3 = new string(new char[] { 'A', 'B', 'C' });

            //Console.WriteLine("s1 == s2 is {0}", s1 == s2);
            //Console.WriteLine("s2 == s3 is {0}", s1 == s3);
            //Console.WriteLine("s1.Equals(s2) is {0}",s1.Equals(s2));
            //Console.WriteLine("s1.Equals(s3) is {0}", s1.Equals(s3));
            //Console.WriteLine("String.ReferenceEquals(s1,s2) is {0}", string.ReferenceEquals(s1,s2));
            //Console.WriteLine("String.ReferenceEquals(s1,s3) is {0}", string.ReferenceEquals(s1, s3));
            //s1 == s3 ? False
            //s1.Equals(s2) ? True
            //s1.Equals(s3) ? True
            //String.ReferenceEquals(s1,s2) ? True

            //char c =s1[1]
            //s1[1] ='X'

            string code = "jp";
            Console.WriteLine("Result is {0}", Utils.isCountryCode(code));
            Console.WriteLine("Result is {0}", code.isCountryCode());

            Console.ReadKey();
        }
    }
}