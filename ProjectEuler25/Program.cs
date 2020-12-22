using System;
using System.Numerics;

namespace ProjectEuler25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFirstFib());
        }

        static long CalculateFirstFib()
        {
            BigInteger fib2 = 1;
            BigInteger fib1 = 1;
            BigInteger fib = fib1 + fib2;
            long counter = 3;
            string fibString = fib.ToString();

            while (fibString.Length < 1000)
            {
                counter++;
                fib2 = fib1;
                fib1 = fib;
                fib = fib1 + fib2;
                fibString = fib.ToString();
                if (counter < 10)
                {
                    Console.WriteLine(fib + "," + counter);
                }
                
            }

            return counter;
        }
    }
}
