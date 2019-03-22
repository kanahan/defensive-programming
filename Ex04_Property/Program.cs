using System;

namespace Ex04_Property
{
    class Person
    {
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            private set //inside class can read write, outside class can only read
            {
                if (value.Length < 5) throw new Exception("Name is too short");
                _Name = value;
            }
        }
        private byte _Age;
        virtual public byte Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value == 0) throw new Exception("Age can't be zero!");
                if (value > 128) throw new Exception("Is this human?");
            }
        }
        public Person(string name)
        {
            Name = name;
        }

        //public void ChangeName(string newName)
        //{
        //    _Name = newName;
        //}
    }

    class Staff : Person
    {
        public double Salary
        {
            get;
            set;
        }
        public Staff(string name, double salary) : base(name)
        {
            Salary = salary;
        }
        override public byte Age
        {
            set
            {
                if (value < 18) throw new Exception("Too young to be staff!");
                if (value > 50) throw new Exception("Give chance to young one-lah");
                base.Age = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("All");

            while (true)
            {
                Console.Write("Age>>");

                try
                {
                    byte Age = byte.Parse(Console.ReadLine());
                    p.Age = Age;
                    Console.WriteLine("{0}'s age is {1}", p.Name, p.Age);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Age can't be zero!");
                }
            }
            Console.ReadKey();
        }
    }
}