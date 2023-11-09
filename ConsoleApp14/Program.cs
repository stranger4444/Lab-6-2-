using ConsoleApp14;

class Program
{
    static void Main()
    {
        
        int a = 5, b = 3;
        Console.WriteLine($"Addition: {MathOperations.Add(a, b)}");
        Console.WriteLine($"Subtraction: {MathOperations.Subtract(a, b)}");
        Console.WriteLine($"Multiplication: {MathOperations.Multiply(a, b)}");

        double[] arrayA = { 1.5, 2.5, 3.5 };
        double[] arrayB = { 0.5, 1.5, 2.5 };
        Console.Write("Array Addition: ");
        MathOperations.PrintArray(MathOperations.Add(arrayA, arrayB));

        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };
        Console.WriteLine("Matrix Addition:");
        MathOperations.PrintMatrix(MathOperations.Add(matrixA, matrixB));

        float[,,] tensorA = { { { 1.0f, 2.0f }, { 3.0f, 4.0f } }, { { 5.0f, 6.0f }, { 7.0f, 8.0f } } };
        float[,,] tensorB = { { { 0.1f, 0.2f }, { 0.3f, 0.4f } }, { { 0.5f, 0.6f }, { 0.7f, 0.8f } } };
        Console.WriteLine("Tensor Addition:");
        MathOperations.PrintTensor(MathOperations.Add(tensorA, tensorB));
    }
}