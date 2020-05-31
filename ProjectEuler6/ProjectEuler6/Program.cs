using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfSquares = 0;
            double sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += Math.Pow(Convert.ToDouble(i), 2);
                sum += i;
            }
            double squareOfSums = Math.Pow(sum, 2);
            double difference = sumOfSquares - squareOfSums;
            Console.WriteLine(difference);
            Console.ReadLine();
        }
    }
}
