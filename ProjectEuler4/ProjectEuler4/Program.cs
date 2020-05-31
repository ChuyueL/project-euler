using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class Program
    {
        static void Main(string[] args)
        {
            string product;
            List<int> palindromeList = new List<int>();
            for (int i = 999; i > 0; i--) //start at 999 to find largest palindrome faster
            {
                for (int j = 999; j > 0; j--)
                {
                    product = Convert.ToString(i * j);
                    List<char> productList = new List<char>(); //list can have unknown number of elements
                    for (int k = 0; k < product.Length; k++)
                    {
                        productList.Add(product[k]);
                    }
                    char[] productArray = productList.ToArray();
                    bool isPalindrome = CheckIfPalindrome(productArray); //convert list to array
                    if (isPalindrome)
                    {
                        palindromeList.Add(Convert.ToInt32(product)); //find all the palindromes first or you'll only find the largest that has 999 as a factor!
                    }                                            
                }
            }
            Console.WriteLine(palindromeList.Max()); //print largest palindrome in list
            Console.ReadLine();
        }
        static bool CheckIfPalindrome(char[] productArray)
        {
            char[] reversedArray = new char[productArray.Length];
            for (int i = 0; i < productArray.Length; i++)
            {
                reversedArray[i] = productArray[productArray.Length - 1 - i]; //as productArray's highest index is it's length-1 (zero based)
            } //reverses the elements of productArray
            string product = String.Join("", productArray);
            string reversed = String.Join("", reversedArray);
            if (product == reversed)
                return true;
            else
                return false;
        }
    }
}
