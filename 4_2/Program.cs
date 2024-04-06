using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_4_01;
class Program
{
    static void Main(string[] args)
    {
        Write("Введите количество строк первой матрицы: ");
        int row1 = int.Parse(ReadLine());
        Write("Введите количество столбцов первой матрицы: ");
        int col1 = int.Parse(ReadLine());

        int[,] matrix1 = new int[row1, col1];

        Random random = new Random();

        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col1; j++)
            {
                matrix1[i, j] = random.Next(10);
                Write($" {matrix1[i,j]} ");
            }
            WriteLine();

        }
        WriteLine("Значения второй матрицы");
        int[,] matrix2 = new int[row1, col1];

        Random random2 = new Random();

        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col1; j++)
            {
                matrix2[i, j] = random.Next(10);
                Write($" {matrix2[i,j]} ");
            }

            WriteLine();
        }
        WriteLine("Значения суммы предыдущих матриц");

        int[,] matrix3 = new int[row1, col1];
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col1; j++)
            {
                matrix3[i, j] = matrix2[i, j] + matrix1[i, j];
                Write($" {matrix3[i,j]} ");
            }
            WriteLine();
        }
    }
}