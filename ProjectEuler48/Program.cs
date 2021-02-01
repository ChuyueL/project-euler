using System;
using System.Numerics;

namespace ProjectEuler48
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = SelfPower(1000);
            string sumString = sum.ToString();
            Console.WriteLine(sumString.Substring(sumString.Length - 10));
            Console.ReadLine();
        }

        static BigInteger SelfPower(int num)
        {
            BigInteger sum = 0;

            for (int i = 1; i < num+1; i++)
            {
                sum += BigInteger.Pow(i, i);
            }

            return sum;
        }

    }
}
