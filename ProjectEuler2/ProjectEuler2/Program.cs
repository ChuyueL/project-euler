using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int previousTerm = 1;
            int currentTerm = 1;
            int nextTerm = 0;
            int total = 0;
            while (previousTerm < 4000000)
            {
                nextTerm = currentTerm + previousTerm;
                previousTerm = currentTerm;
                currentTerm = nextTerm;
                
                if (currentTerm % 2 == 0)
                {
                    total += currentTerm;
                    Console.WriteLine(total);
                }                    
                
            }
            Console.ReadLine();
        }
    }
}
