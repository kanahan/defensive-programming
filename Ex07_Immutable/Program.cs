using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Immutable
{
    sealed class MyImObj
    {
        public readonly int Attr1;
        public readonly float Attr2;
        public MyImObj(int p1, float p2)
        {
            Attr1 = p1;
            Attr2 = p2;
        }
    }

    class X
    {
        int a;
        public X(int a)
        {
            this.a = a;
        }
        public override bool Equals(object obj)
        {
            X rhs = obj as X;
            X lhs = this;
            return lhs.a == rhs.a;
        }
        static public bool operator != (X lhs, X rhs)
        {
            return lhs.a != rhs.a;
        }
        static public bool operator == (X lhs, X rhs)
        {
            return lhs.a == rhs.a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            X x1 = new X(100);
            X x2 = new X(100);

            Console.WriteLine("x1==x2 is {0}", (x1 == x2));
            Console.WriteLine("x1 equals x2 is {0}", (x1.Equals(x2)));
            Console.WriteLine(X.ReferenceEquals(x1, x2));
            Console.ReadKey();
        }
    }
}