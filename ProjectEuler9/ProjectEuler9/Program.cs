using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler9
{
    class Program
    {
        static void Main(string[] args)
        {
            double product = 0;
            for (double a = 1; a < 998; a++)
            {
                for (double b = 1; b < 998; b++)
                {
                    double c2 = Math.Pow(a, 2) + Math.Pow(b, 2);
                    double c = Math.Sqrt(c2);
                    if (a + b + c == 1000)
                    {
                        product = a * b * c;
                        Console.WriteLine(product);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
