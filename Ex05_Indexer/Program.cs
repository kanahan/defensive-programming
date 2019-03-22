using System;
using System.Collections.Generic;

namespace Ex05_Indexer
{
    class MyList
    {
        List<double> items = new List<double>();
        public void Add(double newItem)
        {
            items.Add(newItem);
        }

        public double this[int n]
        {
            get { return items[n]; }
            set { items[n] = value; }
        }

        public double this[string which]
        {
            get
            {
                switch (which.ToUpper())
                {
                    case "FIRST": return items[0];
                    case "LAST": return items[items.Count - 1];
                }
                throw new Exception("No such item:" + which);

            }
            set
            {
                switch (which.ToUpper())
                {
                    case "FIRST": items[0] = value; break;
                    case "LAST": items[items.Count - 1] = value; break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList items = new MyList();
            items.Add(4.4);
            items.Add(3.3);
            items.Add(5.5);
            items.Add(3.3);
            items[0] = 4.7;
            items["Last"] = 3.2;
            double lastValue = items["Last"];
        }
    }
}