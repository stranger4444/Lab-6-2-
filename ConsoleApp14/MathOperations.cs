using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class MathOperations
    {
        public static T Add<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }

        public static T Subtract<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA - dynamicB;
        }

        public static T Multiply<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA * dynamicB;
        }

        

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static void PrintMatrix<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTensor<T>(T[,,] tensor)
        {
            int dimensions = tensor.Rank;

            if (dimensions < 3)
            {
                Console.WriteLine("Invalid tensor dimensions.");
                return;
            }

            int depth = tensor.GetLength(0);
            int rows = tensor.GetLength(1);
            int columns = tensor.GetLength(2);

            for (int i = 0; i < depth; i++)
            {
                Console.WriteLine($"Tensor Layer {i + 1}:");
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        Console.Write($"{tensor[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
