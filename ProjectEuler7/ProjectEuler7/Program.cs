using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler7
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = 2;
            int counter = 1;
            List<int> primeList = new List<int>();
            primeList.Add(currentNumber);
            while (counter <= 10001)
            {
                currentNumber++;
                bool prime = CheckIfPrime(currentNumber);
                if (prime)
                {
                    counter++;
                    primeList.Add(currentNumber);
                }
            }
            Console.WriteLine(primeList[10000]); //accesses 10001st item
            Console.ReadLine();


        }
        static bool CheckIfPrime(int number)
        {
            bool prime = true;
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
                    
            }
            return prime;
        }
    }
}
