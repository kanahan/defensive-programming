using System;

namespace Puzzle8
{
    class Program
    {
        static bool isWellFormed(uint state)
        {
            for (int i = 0; i < 9; i++)
            {
                uint digit = state % 10;
                Console.WriteLine(digit);
                state /= 10;
            }
            return false;
        }

        static bool bitWise_isWellFormed(uint state)
        {
            int flags = 0x000001FF;
            for (int i = 0; i < 9; i++)
            {
                int digit = (int)(state % 10);
                flags &= ~(1 << digit);
                state /= 10;
            }
            return (flags == 0) && (state == 0);
        }

        static uint SwapDigits(uint state, uint p1, uint p2)
        {
            uint d1 = getDigit(state, p1);
            uint d2 = getDigit(state, p2);
            state = setDigit(state, p1, d2);
            state = setDigit(state, p2, d1);
            return state;
        }

        static uint getDigit(uint state, uint p)
        {
            for (uint i = 0; i < p; i++) state /= 10;
            return state % 10;
        }

        static uint setDigit(uint state, uint p, uint d)
        {
            uint result = 0;
            uint m = 1;
            for (int i = 0; i < 9; i++)
            {
                uint digit = state % 10;
                result += m * ((i == p) ? d : digit);
                m *= 10;
                state /= 10;
            }
            return result;
        }

        static void Main(string[] args)
        {
            uint state = 108423675;
            Console.WriteLine(state);
            Console.WriteLine(SwapDigits(state, 5, 7));
            Console.WriteLine(bitWise_isWellFormed(108423675));

            State state2 = new State(7, 4, 6, 8, 2, 5, 1, 3, 0);
            state2.Show();
            Console.ReadKey();
        }
    }
}