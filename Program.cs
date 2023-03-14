using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Lab2
{
    class Program
    {
        int GetMax(int[,] matr, int n)
        {
            
            return 1;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-3, 10);
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                bool negativ = false;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[j,i] < 0)
                    {
                        negativ = true;
                        break;
                    }
                    sum += matrix[j, i];
                }
                if(!negativ)
                {
                    Console.WriteLine("Sum of elements of " + (i + 1) + " column: " + sum);
                }
            }
            int maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                int row = 0, col = i;

                int sum1 = 0, sum2 = 0;
                while (col < n && row < n)
                {
                    if (row == col)
                        break;
                    sum1 += matrix[row, col];
                    sum2 += matrix[col, row];
                    row++;
                    col++;
                }
                maxSum = Math.Max(maxSum, Math.Max(sum1, sum2));
            }
            Console.WriteLine("Max sum " + maxSum);


        }
    }
}