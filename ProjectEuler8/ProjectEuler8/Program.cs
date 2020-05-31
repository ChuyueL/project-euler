using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectEuler8
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumberString = "";
            using (StreamReader sr = new StreamReader("C:\\Users\\ashre\\Documents\\bignumber.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    bigNumberString += line;
                }
            }
            long biggestProduct = 0;
            for (int i = 0; i < bigNumberString.Length - 12; i++)
            {
                long product = 1;
                for (int j = 0; j < 13; j++) //multiplies three adjacent numbers together
                {
                    product = product * int.Parse(Convert.ToString(bigNumberString[i + j])); //convert each character to a number and multiply
                }
                if (product > biggestProduct)
                    biggestProduct = product;
            }
            Console.WriteLine(biggestProduct);
            Console.ReadLine();
        }
    }
}
