using System;

namespace Ex02_Dispose
{
    class X : IDisposable
    {
        string Name;
        public X(string name)
        {
            Name = name;
            Console.Write("Allocate Resources for {0}", name);
        }

        public void Dispose()
        {
            Console.WriteLine("Deallocate resources for {0}", Name);
            GC.SuppressFinalize(this);
        }
        public void DoJob()
        {
            Console.WriteLine("Doing the job....");
        }
        ~X()
        {
            Dispose();
            Console.WriteLine("Deallocate resources for GC}", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            X a = new X("A");
            using (X b = new X("B"))
            {
                Console.WriteLine("Using object b to do job...");
                b.DoJob();
            }
            new X("C"); // Immediate become garbage
            for (int i = 0; i < 10; i++)
            {
                Console.Write("");
                System.Threading.Thread.Sleep(1000);
            }
            System.GC.Collect();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Ended");
            Console.ReadKey();
        }
    }
}