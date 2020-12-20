using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectEuler11
{
    class Program
    {
        static void Main(string[] args)
        {
            String contents = "";
            String line;
            StreamReader sr = new StreamReader("C:\\Users\\chuyu\\Documents\\problem11grid.txt");
            line = sr.ReadLine();
            
            while (line != null)
            {
                contents += line + "\n";
                line = sr.ReadLine();

            }

            Console.WriteLine(contents);

            int[,] grid = new int[20, 20];

            int row = 0;
            int column = 0;
            String number = "";
            foreach (char c in contents)
            {

                if (c == '\n')
                {
                    if (row != 19)
                    {
                        row++;
                        column = 0;
                    }
                    
                    grid[row, column] = Int32.Parse(number);
                    number = "";
                   
                }
                else if (c == ' ')
                {
                    grid[row, column] = Int32.Parse(number);
                    column++;
                    number = "";
                }
                else
                {
                    number += c;
                }


            }
            long product = CalculateLargestProduct(grid);
            Console.WriteLine(product);
            Console.ReadLine();
        }

        static long CalculateLargestProduct(int[,] grid)
        {
            long maxProduct = 0;

            for (int r = 0; r < 20; r++)
            {
                for (int c = 0; c < 20; c++)
                {
                    int[][,] coords =
                    {
                        new int[,] { { r - 1, c }, { r - 2, c }, { r - 3, c } }, // up
                        new int[,] {{ r + 1, c}, { r + 2, c}, { r+3, c} }, //down
                        new int[,] {{ r, c - 1}, { r, c - 2}, { r, c -3} }, //left
                        new int[,] {{ r , c+1}, { r, c + 2}, { r, c+3} }, //right
                        new int[,] {{ r - 1, c - 1}, { r - 2, c - 2}, { r - 3, c - 3} }, //diagonals
                        new int[,] {{ r + 1, c + 1}, { r + 2, c + 2}, { r + 3, c+3} },
                        new int[,] {{ r - 1, c + 1}, { r - 2, c + 2}, { r -3, c+3} },
                        new int[,] {{ r + 1, c - 1}, { r + 2, c - 2}, { r + 3, c - 3} }
                    };
                    //array of coordinates
                    //foreach loop in array
                    /*
                    long product = 0;
                    if (r - 4 >= 0) //up
                    {
                        product = CalculateUp(grid, r, c);
                    }

                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                    */

                    foreach (int[,] coord in coords) {
                        long product = grid[r, c];
                        for (int i = 0; i < 3; i++)
                        {
                            if (coord[i, 0] >= 0 && coord[i, 0] <= 19 && coord[i, 1] >= 0 && coord[i, 1] <=19 )
                            {
                                product *= grid[coord[i, 0], coord[i, 1]];
                            }
                            else
                            {
                                product = 0;
                            }
                            
                        }
                        if (product > maxProduct) {
                            maxProduct = product;
                        }
                    }
                }
            }
            return maxProduct;
        }

        /* tried to do something smart but would probably just make it longer 
        long CalculateUp(int[,] grid, int row, int col)
        {
            int currentRow = row;
            int currentCol = col;
            long product = grid[row, col];
            for (int i = 0; i < 3; i++)
            {
                currentRow -= 1;
                product *= grid[currentRow, currentCol];
                
            }

            return product;
        }

        long CalculateDown(int[,] grid, int row, int col)
        {
            int currentRow = row;
            int currentCol = col;
            long product = grid[row, col];
            for (int i = 0; i < 3; i++)
            {
                currentRow++;
                product *= grid[currentRow, currentCol];
            }
            return product;
        }
        
        long CalculateLeft(int[,]grid, int row, int col)
        {
            int currentRow = row;
            int currentCol = col;
            long product = grid[row, col];
            for (int i = 0; i < 3; i++)
            {
                currentCol--;
                product *= grid[currentRow, currentCol];
            }
            return product;

        }

        long CalculateRight(int[,] grid, int row, int col)
        {
            int currentRow = row;
            int currentCol = col;
            long product = grid[row, col];
            for (int i = 0; i < 3; i++)
            {
                currentCol++;
                product *= grid[currentRow, currentCol];
            }
            return product;
        }
        */

    }
}
