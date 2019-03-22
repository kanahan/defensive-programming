using System;

namespace Puzzle8
{
    class State
    {
        readonly uint slots;
        public State(uint d0, uint d1, uint d2, uint d3, uint d4, uint d5, uint d6, uint d7, uint d8)
        {
            slots = d0 + 
                d1 * 10 +
                d2 * 100 +
                d3 * 1000 +
                d4 * 10000 +
                d5 * 100000 +
                d6 * 1000000 +
                d7 * 10000000 +
                d8 * 100000000;
            Console.WriteLine(slots);
        }

        public void Show()
        {
            uint slots = this.slots;
            for (int i = 0; i < 9; i++)
            {
                uint digit = slots % 10;
                if (digit == 0)
                    Console.Write("_");
                else
                    Console.Write(digit);
                if (((i + 1) % 3) == 0) Console.WriteLine();
                slots /= 10;
            }
            Console.WriteLine();
        }
    }
}
