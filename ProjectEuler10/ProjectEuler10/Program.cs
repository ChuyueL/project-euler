using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 2; i < 2000000; i++)
            {
                    bool isPrime = CheckIfPrime(i);
                    if (isPrime)
                    {
                        sum += i;
                        //Console.WriteLine(sum);
                    }
                                                                 
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static bool CheckIfPrime(int number)
        {
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    return prime;
                }
            }
            return prime;
        }
    }
}
