using System;

namespace Ex09_Casting
{
    class Asian
    {
        public void EatGrass() { }
        virtual public void Drive()
        {
            Console.WriteLine("Drive at left hand side");
        }
    }

    class Malaysian : Asian
    {
        public void Steady()
        {
            Console.Write("I am Steady");
        }
        override public void Drive()
        {
            Console.WriteLine("Drive at right hand side");
        }
    }

    class Singaporean : Asian
    {
        public void Kanasai()
        {
            Console.Write("I am Kanasai");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Malaysian m = new Malaysian();
            Singaporean s = new Singaporean();
            Asian a = m;

            a.Drive();

            Malaysian m2 = a as Malaysian; //safe casting
            if (m2 != null)
            {
                m2.Steady();
            }

            if (a is Malaysian)
            {
                ((Malaysian)a).Steady(); // unsafe casting in multithread env
            }
            else
            {
                Console.WriteLine("Not Steady");
            }
            Console.ReadKey();
        }
    }
}