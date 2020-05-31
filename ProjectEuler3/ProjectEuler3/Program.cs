using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            long largestPrimeFactor = 1;
            long newNumber = number;
            //for (int i = 1; i < number / 2; i++)
            //{
            //    if (number % i == 0)
            //        Console.WriteLine(i);
            //}
            for (long i = number/71; i > 1; i--)
            {
                if (number % (71*i) == 0) //if n is divisible by i then it is divisible by 71i as 71 is a factor (as long as i < n/71)
                {
                    bool prime = CheckIfPrime(i);
                    if (prime)
                    {
                        largestPrimeFactor = i;
                        Console.WriteLine(largestPrimeFactor);
                        break;
                    }
                    else
                        i = i / 71; //therefore if n is not divisible by 71i then divide by i by 71 (see notebook)
                    
                }
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        static bool CheckIfPrime(long number)
        {
            bool prime = true;
            for (long i = 2; i < number/2; i++)
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
