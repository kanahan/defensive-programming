using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Parsing
{
    class X
    {
        public string Name;
        public X(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Test1(X rx)
        {
            rx = new X("AAA");
        }
        static void Test2(ref X rx)
        {
            rx = new X("BBB");
        }
        static void Test3a(X rx)
        {
            rx.Name = "A";
            rx = new X("AAA");
        }
        static void Test3b(ref X rx)
        {
            rx.Name = "B";
            rx = new X("BBB");
        }
        static void Test4a(out X rx)
        {
            //string name = rx.Name; // Not allow to read
            rx = new X("BBB");
        }
        static void Test4b(in X rx)
        {
            string name = rx.Name;
            //rx = new X("BBB"); // Not allow to write
            rx.Name = "DDD";
        }

        static void Main (string [] args)
        {
            X x = new X("X");
            Test1(x);
            Console.WriteLine("1: {0}", x.Name);
            Test2(ref x);
            Console.WriteLine("2: {0}", x.Name);

            X x3 = new X("X");
            Test3a(x3);
            Console.WriteLine("1: {0}", x3.Name);
            Test3b(ref x3);
            Console.WriteLine("2: {0}", x3.Name);
            Console.ReadKey();
        }


        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void ModDiv(int x, int y, ref int m, out int d)
        {
            m = x % y;
            d = x / y;
        }

        // reference readonly 
        static void CallByRefOnly(in int v)
        {
            int v2 = 2 * v;
            //v = 199; // cause error becaues v is readonly
        }

        static void Main2(string[] args)
        {
            int x = 22, y = 7;
            //Console.WriteLine("x:{0} y{1}", x, y);
            //Swap(ref x, ref y);
            //Console.WriteLine("x:{0} y{1}", x, y);
            int mod = 0, div = 0;
            ModDiv(x, y, ref mod, out div);
            Console.WriteLine("Mod:{0} Div:{1}", mod, div);
            Console.ReadKey();
        }
    }
}