using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Enum
{
    enum Month { JAN = 1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC };

    class Program
    {
        static bool IsLeapYear(uint year)
        {
            if ((year % 4) != 0) return false;
            if ((year % 100) != 0) return true;
            if ((year % 400) != 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Years>>");
            uint y = uint.Parse(Console.ReadLine());
            foreach (Month m in Enum.GetValues(typeof(Month)))
            {
                uint n = 31;
                switch (m)
                {
                    case Month.FEB:
                        n = IsLeapYear(y) ? 29u : 28u;
                        break;
                    case Month.APR:
                    case Month.JUN:
                    case Month.SEP:
                    case Month.NOV:
                        n = 30;
                        break;
                }
                Console.WriteLine("{0}{1}", m, n);
            }
            Console.ReadKey();
        }
    }
}