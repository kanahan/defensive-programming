using System;

namespace Ex06_Overflow_Underflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.MaxValue;
            checked
            {
                n = n + 1;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
