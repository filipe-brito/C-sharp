using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int M, N;
        double soma;

        Console.Write("Qual a quantidade de linhas da matriz? ");
        M = int.Parse(Console.ReadLine());
        Console.Write("Qual a quantidade de colunas da matriz? ");
        N = int.Parse(Console.ReadLine());

        double[,] mat = new double[M, N];
        double[] vet = new double[M];

        for (int loopl = 0; loopl < M; loopl++)
        {
            soma = 0;
            Console.WriteLine("Digite os elementos da " + (loopl + 1) + "a. linha: ");
            for (int loopc = 0; loopc < N; loopc++)
            {
                mat[loopl, loopc] = double.Parse(Console.ReadLine(), CI);
                soma = soma + mat[loopl, loopc];
            }
            vet[loopl] = soma;
        }
        Console.WriteLine("VETOR GERADO: ");
        for (int loop = 0; loop < M; loop++)
        {
            Console.WriteLine(vet[loop].ToString("F1", CI));
        }
    }
}