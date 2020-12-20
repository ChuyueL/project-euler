using System;
using System.Numerics;

namespace ProjectEuler20
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = CalculateFactorialDigitSum(100);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        
        static long CalculateFactorialDigitSum(int n)
        {
            BigInteger factorial = 1;
            
            for (int i = 2; i <= n; i++)
            {
                factorial *= (ulong)i;
            }
            Console.WriteLine(factorial);
            long sum = 0;
            
            /*
            long number = factorial;
            while (number > 0)
            {
                long temp = number % (long)10; //get rightmost digit
                sum += (int)temp;
                temp = temp / 10;

            }
            */
            string factString = factorial.ToString();
            foreach (char c in factString)
            {
                int digit = Int32.Parse(c.ToString());
                sum += digit;
            }

            return sum;
            
        }
    }
}
