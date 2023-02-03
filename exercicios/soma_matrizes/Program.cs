using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int M, N;

        Console.Write("Quantas linhas vai ter cada matriz? ");
        M = int.Parse(Console.ReadLine());
        Console.Write("Quantas colunas vai ter cada matriz? ");
        N = int.Parse(Console.ReadLine());

        int[,] matA = new int[M, N];
        int[,] matB = new int[M, N];
        int[,] matC = new int[M, N];

        Console.WriteLine("Digite os valores da matriz A: ");
        for (int loopl = 0; loopl < M; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                Console.Write("Elemento [" + loopl + "," + loopc + "]:");
                matA[loopl, loopc] = int.Parse(Console.ReadLine()); 
            }
        }

        Console.WriteLine("Digite os valores da matriz B: ");
        for (int loopl = 0; loopl < M; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                Console.Write("Elemento [" + loopl + "," + loopc + "]:");
                matB[loopl, loopc] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("MATRIZ SOMA: ");
        for (int loopl = 0; loopl < M; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                matC[loopl, loopc] = matA[loopl, loopc] + matB[loopl, loopc];
                Console.Write(matC[loopl, loopc] + "  ");
            }
            Console.WriteLine();
        }
    }
}