using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {

        static void FOne(int[,] mat, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void FTwo(int[,] mat, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void FThree(int[,] matA, int[,] matB, int[,] matC, int n1, int m1, int n2, int m2)
        {
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    for (int g = 0; g < m1; g++)
                    {

                        matC[i, j] += matA[i, g] * matB[g, j];


                    }
                    Console.Write(matC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] mat1;
            int[,] mat2;
            int[,] mat3;
            int n1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            mat1 = new int[n1, m1];
            mat2 = new int[n2, m2];
            FOne(mat1, n1, m1);
            FTwo(mat1, n1, m1);
            Console.WriteLine();
            FOne(mat2, n2, m2);
            FTwo(mat2, n2, m2);
            Console.WriteLine();
            mat3 = new int[n2, m1];
            if (m1 == n2)
            {
                FThree(mat1, mat2, mat3, n1, m1, n2, m2);
            }
            else
            {
                Console.WriteLine("Умножение матриц невозможно");
            }
            Console.ReadKey();
        }
    }
}
