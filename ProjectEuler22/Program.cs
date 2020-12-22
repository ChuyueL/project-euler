using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace ProjectEuler22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\chuyu\\Documents\\p022_names.txt"))
                {
                    char c;
                    string name = "";
                    while (sr.Peek() > -1)
                    {
                        c = (char)sr.Read();
                        if (c == ',')
                        {
                            names.Add(name);
                            name = "";
                            
                        } 
                        else if (c != '"')
                        {
                            name = name + c;
                        }
                        
                    }
                    names.Add(name); //Add last name in file

                }

            }
            catch (Exception)
            {
                throw;
            }

            names.Sort();

            BigInteger total = 0;
            

            foreach (string name in names)
            {
                total += CalculateScore(name, names.IndexOf(name) + 1);
            }

            Console.WriteLine(total);
            Console.ReadLine();
            
        }

        static int CalculateScore(string name, int pos)
        {
            int score = 0;
            foreach (char c in name)
            {
                int index = char.ToUpper(c) - 64; //Find position of the character in alphabet
                score += index;
            }
            score *= pos;

            return score;
        }
    }
}
